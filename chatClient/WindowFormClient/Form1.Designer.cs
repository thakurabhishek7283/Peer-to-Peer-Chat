namespace chatui
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
            this.ipList = new System.Windows.Forms.ListBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.message_box = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.Chat_Window = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.Fetch_server = new System.Windows.Forms.Button();
            this.port_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipList
            // 
            this.ipList.FormattingEnabled = true;
            this.ipList.Location = new System.Drawing.Point(0, 0);
            this.ipList.Name = "ipList";
            this.ipList.Size = new System.Drawing.Size(208, 225);
            this.ipList.TabIndex = 0;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(133, 231);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 1;
            this.connect_button.Text = "connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(0, 323);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(208, 97);
            this.message_box.TabIndex = 3;
            this.message_box.Text = "";
            // 
            // send
            // 
            this.send.Enabled = false;
            this.send.Location = new System.Drawing.Point(133, 429);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 4;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Chat_Window
            // 
            this.Chat_Window.FormattingEnabled = true;
            this.Chat_Window.Location = new System.Drawing.Point(240, 0);
            this.Chat_Window.Name = "Chat_Window";
            this.Chat_Window.Size = new System.Drawing.Size(273, 381);
            this.Chat_Window.TabIndex = 5;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(438, 397);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Fetch_server
            // 
            this.Fetch_server.Location = new System.Drawing.Point(0, 231);
            this.Fetch_server.Name = "Fetch_server";
            this.Fetch_server.Size = new System.Drawing.Size(75, 23);
            this.Fetch_server.TabIndex = 7;
            this.Fetch_server.Text = "Latest list";
            this.Fetch_server.UseVisualStyleBackColor = true;
            this.Fetch_server.Click += new System.EventHandler(this.Fetch_server_Click);
            // 
            // port_input
            // 
            this.port_input.Location = new System.Drawing.Point(108, 281);
            this.port_input.Name = "port_input";
            this.port_input.Size = new System.Drawing.Size(100, 20);
            this.port_input.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_input);
            this.Controls.Add(this.Fetch_server);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Chat_Window);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.ipList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ipList;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.RichTextBox message_box;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Fetch_server;
        private System.Windows.Forms.TextBox port_input;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox Chat_Window;
    }
}

