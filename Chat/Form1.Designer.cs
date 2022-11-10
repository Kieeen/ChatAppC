namespace Chat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.txtMainServer = new System.Windows.Forms.TextBox();
            this.txtMessageServer = new System.Windows.Forms.TextBox();
            this.btnSendServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(161, 108);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 39);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(476, 111);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(124, 39);
            this.txtPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(775, 104);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(150, 46);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(952, 104);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(150, 46);
            this.btnStopServer.TabIndex = 5;
            this.btnStopServer.Text = "Stop";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // txtMainServer
            // 
            this.txtMainServer.Location = new System.Drawing.Point(161, 156);
            this.txtMainServer.Multiline = true;
            this.txtMainServer.Name = "txtMainServer";
            this.txtMainServer.Size = new System.Drawing.Size(941, 303);
            this.txtMainServer.TabIndex = 6;
            // 
            // txtMessageServer
            // 
            this.txtMessageServer.Location = new System.Drawing.Point(161, 481);
            this.txtMessageServer.Name = "txtMessageServer";
            this.txtMessageServer.Size = new System.Drawing.Size(941, 39);
            this.txtMessageServer.TabIndex = 7;
            // 
            // btnSendServer
            // 
            this.btnSendServer.Location = new System.Drawing.Point(952, 539);
            this.btnSendServer.Name = "btnSendServer";
            this.btnSendServer.Size = new System.Drawing.Size(150, 46);
            this.btnSendServer.TabIndex = 8;
            this.btnSendServer.Text = "Send";
            this.btnSendServer.UseVisualStyleBackColor = true;
            this.btnSendServer.Click += new System.EventHandler(this.btnSendServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 656);
            this.Controls.Add(this.btnSendServer);
            this.Controls.Add(this.txtMessageServer);
            this.Controls.Add(this.txtMainServer);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtHost;
        private TextBox txtPort;
        private Label label2;
        private Button btnStartServer;
        private Button btnStopServer;
        private TextBox txtMainServer;
        private TextBox txtMessageServer;
        private Button btnSendServer;
    }
}