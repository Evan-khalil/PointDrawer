using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2._1
{
    public partial class Form1 : Form
    {
        public Socket ListnerSocket;
        public Socket SenderSocket;
        public BinaryFormatter Serialiser;
        public Action<Points> GetPoints;
        public bool IsListening;
        private bool IsDrawing;
        private Point Point;
        private readonly Pen Pen;
        private readonly Graphics Drawer;
        public Form1()
        {
            InitializeComponent();
            ListnerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            SenderSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Serialiser = new BinaryFormatter();
            GetPoints = null;
            Drawer = Panel.CreateGraphics();
            Pen = new Pen(Color.Red);
            Point = new Point();
            SetPoints(Draw);
        }
        public void Listen()
        {
            while (IsListening)
            {
                int availableBytes = ListnerSocket.Available;
                if (availableBytes <= 0)
                {
                    continue;
                }
                byte[] byteBuffer = new byte[availableBytes];
                ListnerSocket.Receive(byteBuffer, availableBytes, SocketFlags.None);
                using (MemoryStream stream = new MemoryStream(byteBuffer))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    object deserializedBytes = Serialiser.Deserialize(stream);
                    if (deserializedBytes is Points point)
                    {
                        GetPoints?.Invoke(point);
                    }
                }
            }
        }
        public void SetPoints(Action<Points> setPoints)
        {
            GetPoints = setPoints;
        }
        public void Send(object bytes)
        {
            byte[] serializedBytes;
            using (MemoryStream stream = new MemoryStream())
            {
                Serialiser.Serialize(stream, bytes);
                serializedBytes = stream.ToArray();
            }
            if (serializedBytes.Length <= 0)
            {
                return;
            }
            SenderSocket.Send(serializedBytes);
        }
        private void Draw(Points point)
        {
            Drawer.DrawLine(Pen, point.P1, point.P2);
        }
        private void StartSending(object sender, EventArgs e)
        {
            SenderSocket.Connect(IPAddress.Parse(SenderIp.Text.ToString()), int.Parse(SenderPort.Text));
        }
        private void StartListening(object sender, EventArgs e)
        {
            ListnerSocket.Bind(new IPEndPoint(IPAddress.Parse(ListnerIp.Text.ToString()), int.Parse(ListnerPort.Text)));
            IsListening = true;
            Task.Factory.StartNew(Listen, TaskCreationOptions.LongRunning);
        }
        private void StartDrawing(object sender, MouseEventArgs e)
        {
            IsDrawing = true;
        }
        private void Drawing(object sender, MouseEventArgs e)
        {
            if (IsDrawing && !Point.IsEmpty)
            {
                Points point = new Points(Point, e.Location);
                Draw(point);
                Send(point);
            }

            Point = e.Location;
        }
        private void StopDrawing(object sender, MouseEventArgs e)
        {
            IsDrawing = false;
        }
    }
}
