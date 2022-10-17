namespace _2._2._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListnerIp = new System.Windows.Forms.TextBox();
            this.ListnerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SenderPort = new System.Windows.Forms.TextBox();
            this.SenderIp = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ListnerIp
            // 
            this.ListnerIp.Location = new System.Drawing.Point(118, 34);
            this.ListnerIp.Name = "ListnerIp";
            this.ListnerIp.Size = new System.Drawing.Size(196, 38);
            this.ListnerIp.TabIndex = 1;
            // 
            // ListnerPort
            // 
            this.ListnerPort.Location = new System.Drawing.Point(118, 104);
            this.ListnerPort.Name = "ListnerPort";
            this.ListnerPort.Size = new System.Drawing.Size(110, 38);
            this.ListnerPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start Listening";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartListening);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1029, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Start Sending";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StartSending);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP";
            // 
            // SenderPort
            // 
            this.SenderPort.Location = new System.Drawing.Point(816, 107);
            this.SenderPort.Name = "SenderPort";
            this.SenderPort.Size = new System.Drawing.Size(110, 38);
            this.SenderPort.TabIndex = 7;
            // 
            // SenderIp
            // 
            this.SenderIp.Location = new System.Drawing.Point(816, 37);
            this.SenderIp.Name = "SenderIp";
            this.SenderIp.Size = new System.Drawing.Size(196, 38);
            this.SenderIp.TabIndex = 6;
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(18, 176);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(2669, 1055);
            this.Panel.TabIndex = 11;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawing);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawing);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDrawing);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2722, 1243);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SenderPort);
            this.Controls.Add(this.SenderIp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListnerPort);
            this.Controls.Add(this.ListnerIp);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ListnerIp;
        private System.Windows.Forms.TextBox ListnerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SenderPort;
        private System.Windows.Forms.TextBox SenderIp;
        private System.Windows.Forms.Panel Panel;
    }
}

