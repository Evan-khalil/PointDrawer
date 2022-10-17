using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2._2._1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    [Serializable]
    public struct Points
    {
        public Point P1 { get; }
        public Point P2 { get; }
        public Points(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }
    }
}
