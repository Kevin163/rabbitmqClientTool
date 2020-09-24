namespace RabbitMQClientTool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userTitle = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.portTitle = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.host = new System.Windows.Forms.TextBox();
            this.hostTitle = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.pwdTitle = new System.Windows.Forms.Label();
            this.vhost = new System.Windows.Forms.TextBox();
            this.vhostTitle = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.vhostTitle);
            this.groupBox1.Controls.Add(this.vhost);
            this.groupBox1.Controls.Add(this.pwdTitle);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.userTitle);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.portTitle);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.host);
            this.groupBox1.Controls.Add(this.hostTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "connect test";
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Location = new System.Drawing.Point(328, 24);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(38, 17);
            this.userTitle.TabIndex = 0;
            this.userTitle.Text = "User:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(373, 21);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(116, 23);
            this.user.TabIndex = 1;
            // 
            // portTitle
            // 
            this.portTitle.AutoSize = true;
            this.portTitle.Location = new System.Drawing.Point(196, 24);
            this.portTitle.Name = "portTitle";
            this.portTitle.Size = new System.Drawing.Size(35, 17);
            this.portTitle.TabIndex = 0;
            this.portTitle.Text = "Port:";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(238, 21);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(83, 23);
            this.port.TabIndex = 1;
            this.port.Text = "5672";
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(58, 21);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(131, 23);
            this.host.TabIndex = 1;
            // 
            // hostTitle
            // 
            this.hostTitle.AutoSize = true;
            this.hostTitle.Location = new System.Drawing.Point(13, 24);
            this.hostTitle.Name = "hostTitle";
            this.hostTitle.Size = new System.Drawing.Size(38, 17);
            this.hostTitle.TabIndex = 0;
            this.hostTitle.Text = "Host:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(570, 21);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(131, 23);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // pwdTitle
            // 
            this.pwdTitle.AutoSize = true;
            this.pwdTitle.Location = new System.Drawing.Point(496, 24);
            this.pwdTitle.Name = "pwdTitle";
            this.pwdTitle.Size = new System.Drawing.Size(67, 17);
            this.pwdTitle.TabIndex = 0;
            this.pwdTitle.Text = "Password:";
            // 
            // vhost
            // 
            this.vhost.Location = new System.Drawing.Point(761, 21);
            this.vhost.Name = "vhost";
            this.vhost.Size = new System.Drawing.Size(97, 23);
            this.vhost.TabIndex = 1;
            this.vhost.Text = "/";
            // 
            // vhostTitle
            // 
            this.vhostTitle.AutoSize = true;
            this.vhostTitle.Location = new System.Drawing.Point(708, 24);
            this.vhostTitle.Name = "vhostTitle";
            this.vhostTitle.Size = new System.Drawing.Size(46, 17);
            this.vhostTitle.TabIndex = 0;
            this.vhostTitle.Text = "VHost:";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(865, 21);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 2;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 717);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "rabbitmq client tool V1.0 powered by chenql163@163.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label hostTitle;
        private System.Windows.Forms.Label portTitle;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label userTitle;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label vhostTitle;
        private System.Windows.Forms.TextBox vhost;
        private System.Windows.Forms.Label pwdTitle;
        private System.Windows.Forms.TextBox password;
    }
}

