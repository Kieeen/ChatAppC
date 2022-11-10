namespace ClientChat
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
            this.btnSendClient = new System.Windows.Forms.Button();
            this.txtMessageClient = new System.Windows.Forms.TextBox();
            this.txtMainClient = new System.Windows.Forms.TextBox();
            this.btnConnectClient = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendClient
            // 
            this.btnSendClient.Location = new System.Drawing.Point(995, 544);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(150, 46);
            this.btnSendClient.TabIndex = 17;
            this.btnSendClient.Text = "Send";
            this.btnSendClient.UseVisualStyleBackColor = true;
            this.btnSendClient.Click += new System.EventHandler(this.btnSendClient_Click);
            // 
            // txtMessageClient
            // 
            this.txtMessageClient.Location = new System.Drawing.Point(204, 486);
            this.txtMessageClient.Name = "txtMessageClient";
            this.txtMessageClient.Size = new System.Drawing.Size(941, 39);
            this.txtMessageClient.TabIndex = 16;
            // 
            // txtMainClient
            // 
            this.txtMainClient.Location = new System.Drawing.Point(204, 161);
            this.txtMainClient.Multiline = true;
            this.txtMainClient.Name = "txtMainClient";
            this.txtMainClient.Size = new System.Drawing.Size(941, 303);
            this.txtMainClient.TabIndex = 15;
            // 
            // btnConnectClient
            // 
            this.btnConnectClient.Location = new System.Drawing.Point(995, 109);
            this.btnConnectClient.Name = "btnConnectClient";
            this.btnConnectClient.Size = new System.Drawing.Size(150, 46);
            this.btnConnectClient.TabIndex = 14;
            this.btnConnectClient.Text = "Connect";
            this.btnConnectClient.UseVisualStyleBackColor = true;
            this.btnConnectClient.Click += new System.EventHandler(this.btnConnectClient_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(519, 116);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(124, 39);
            this.txtPort.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(204, 113);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 39);
            this.txtHost.TabIndex = 10;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Host:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 724);
            this.Controls.Add(this.btnSendClient);
            this.Controls.Add(this.txtMessageClient);
            this.Controls.Add(this.txtMainClient);
            this.Controls.Add(this.btnConnectClient);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSendClient;
        private TextBox txtMessageClient;
        private TextBox txtMainClient;
        private Button btnConnectClient;
        private TextBox txtPort;
        private Label label2;
        private TextBox txtHost;
        private Label label1;
    }
}