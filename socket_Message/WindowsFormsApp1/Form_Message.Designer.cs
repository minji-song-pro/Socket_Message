namespace Socket_Message
{
	partial class Form_Message
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Message));
			this.statusStrip_bar = new System.Windows.Forms.StatusStrip();
			this.toolStripStatus_lb_time = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip_bar = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripBtn_connect = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtn_disconnect = new System.Windows.Forms.ToolStripButton();
			this.panel_message = new System.Windows.Forms.Panel();
			this.btn_send = new System.Windows.Forms.Button();
			this.tb_message = new System.Windows.Forms.TextBox();
			this.panel_setup = new System.Windows.Forms.Panel();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_setup = new System.Windows.Forms.Button();
			this.cb_server = new System.Windows.Forms.CheckBox();
			this.tb_ip = new System.Windows.Forms.TextBox();
			this.tb_port = new System.Windows.Forms.TextBox();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.lb_port = new System.Windows.Forms.Label();
			this.lb_id = new System.Windows.Forms.Label();
			this.lb_ip = new System.Windows.Forms.Label();
			this.richtb_message = new System.Windows.Forms.RichTextBox();
			this.statusStrip_bar.SuspendLayout();
			this.toolStrip_bar.SuspendLayout();
			this.panel_message.SuspendLayout();
			this.panel_setup.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip_bar
			// 
			this.statusStrip_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_lb_time});
			this.statusStrip_bar.Location = new System.Drawing.Point(0, 348);
			this.statusStrip_bar.Name = "statusStrip_bar";
			this.statusStrip_bar.Size = new System.Drawing.Size(263, 22);
			this.statusStrip_bar.TabIndex = 0;
			this.statusStrip_bar.Text = "statusStrip1";
			// 
			// toolStripStatus_lb_time
			// 
			this.toolStripStatus_lb_time.Name = "toolStripStatus_lb_time";
			this.toolStripStatus_lb_time.Size = new System.Drawing.Size(99, 17);
			this.toolStripStatus_lb_time.Text = "메시지 받은 시간";
			// 
			// toolStrip_bar
			// 
			this.toolStrip_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripBtn_connect,
            this.toolStripBtn_disconnect});
			this.toolStrip_bar.Location = new System.Drawing.Point(0, 0);
			this.toolStrip_bar.Name = "toolStrip_bar";
			this.toolStrip_bar.Size = new System.Drawing.Size(263, 25);
			this.toolStrip_bar.TabIndex = 1;
			this.toolStrip_bar.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// 설정ToolStripMenuItem
			// 
			this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
			this.설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.설정ToolStripMenuItem.Text = "설정";
			this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
			// 
			// 닫기ToolStripMenuItem
			// 
			this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
			this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.닫기ToolStripMenuItem.Text = "닫기";
			this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
			// 
			// toolStripBtn_connect
			// 
			this.toolStripBtn_connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtn_connect.Enabled = false;
			this.toolStripBtn_connect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_connect.Image")));
			this.toolStripBtn_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtn_connect.Name = "toolStripBtn_connect";
			this.toolStripBtn_connect.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtn_connect.Text = "toolStripButton2";
			this.toolStripBtn_connect.Click += new System.EventHandler(this.toolStripBtn_connect_Click);
			// 
			// toolStripBtn_disconnect
			// 
			this.toolStripBtn_disconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtn_disconnect.Enabled = false;
			this.toolStripBtn_disconnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_disconnect.Image")));
			this.toolStripBtn_disconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtn_disconnect.Name = "toolStripBtn_disconnect";
			this.toolStripBtn_disconnect.Size = new System.Drawing.Size(23, 22);
			this.toolStripBtn_disconnect.Text = "toolStripButton3";
			// 
			// panel_message
			// 
			this.panel_message.Controls.Add(this.btn_send);
			this.panel_message.Controls.Add(this.tb_message);
			this.panel_message.Location = new System.Drawing.Point(0, 278);
			this.panel_message.Name = "panel_message";
			this.panel_message.Size = new System.Drawing.Size(259, 61);
			this.panel_message.TabIndex = 3;
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(193, 9);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(61, 43);
			this.btn_send.TabIndex = 1;
			this.btn_send.Text = "보내기";
			this.btn_send.UseVisualStyleBackColor = true;
			// 
			// tb_message
			// 
			this.tb_message.Location = new System.Drawing.Point(10, 9);
			this.tb_message.Multiline = true;
			this.tb_message.Name = "tb_message";
			this.tb_message.Size = new System.Drawing.Size(177, 43);
			this.tb_message.TabIndex = 0;
			// 
			// panel_setup
			// 
			this.panel_setup.Controls.Add(this.btn_close);
			this.panel_setup.Controls.Add(this.btn_setup);
			this.panel_setup.Controls.Add(this.cb_server);
			this.panel_setup.Controls.Add(this.tb_ip);
			this.panel_setup.Controls.Add(this.tb_port);
			this.panel_setup.Controls.Add(this.tb_id);
			this.panel_setup.Controls.Add(this.lb_port);
			this.panel_setup.Controls.Add(this.lb_id);
			this.panel_setup.Controls.Add(this.lb_ip);
			this.panel_setup.Location = new System.Drawing.Point(25, 73);
			this.panel_setup.Name = "panel_setup";
			this.panel_setup.Size = new System.Drawing.Size(200, 155);
			this.panel_setup.TabIndex = 4;
			this.panel_setup.Visible = false;
			// 
			// btn_close
			// 
			this.btn_close.Location = new System.Drawing.Point(108, 105);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(66, 23);
			this.btn_close.TabIndex = 3;
			this.btn_close.Text = "닫기";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_setup
			// 
			this.btn_setup.Location = new System.Drawing.Point(27, 120);
			this.btn_setup.Name = "btn_setup";
			this.btn_setup.Size = new System.Drawing.Size(64, 23);
			this.btn_setup.TabIndex = 3;
			this.btn_setup.Text = "설정";
			this.btn_setup.UseVisualStyleBackColor = true;
			this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
			// 
			// cb_server
			// 
			this.cb_server.AutoSize = true;
			this.cb_server.Location = new System.Drawing.Point(27, 92);
			this.cb_server.Name = "cb_server";
			this.cb_server.Size = new System.Drawing.Size(72, 16);
			this.cb_server.TabIndex = 2;
			this.cb_server.Text = "서버실행";
			this.cb_server.UseVisualStyleBackColor = true;
			this.cb_server.CheckedChanged += new System.EventHandler(this.cb_server_CheckedChanged);
			// 
			// tb_ip
			// 
			this.tb_ip.Location = new System.Drawing.Point(74, 15);
			this.tb_ip.Name = "tb_ip";
			this.tb_ip.Size = new System.Drawing.Size(100, 21);
			this.tb_ip.TabIndex = 1;
			// 
			// tb_port
			// 
			this.tb_port.Enabled = false;
			this.tb_port.Location = new System.Drawing.Point(74, 65);
			this.tb_port.Name = "tb_port";
			this.tb_port.Size = new System.Drawing.Size(100, 21);
			this.tb_port.TabIndex = 1;
			// 
			// tb_id
			// 
			this.tb_id.Location = new System.Drawing.Point(74, 40);
			this.tb_id.Name = "tb_id";
			this.tb_id.Size = new System.Drawing.Size(100, 21);
			this.tb_id.TabIndex = 1;
			// 
			// lb_port
			// 
			this.lb_port.AutoSize = true;
			this.lb_port.Location = new System.Drawing.Point(25, 69);
			this.lb_port.Name = "lb_port";
			this.lb_port.Size = new System.Drawing.Size(46, 12);
			this.lb_port.TabIndex = 0;
			this.lb_port.Text = "PORT :";
			// 
			// lb_id
			// 
			this.lb_id.AutoSize = true;
			this.lb_id.Location = new System.Drawing.Point(25, 44);
			this.lb_id.Name = "lb_id";
			this.lb_id.Size = new System.Drawing.Size(24, 12);
			this.lb_id.TabIndex = 0;
			this.lb_id.Text = "ID :";
			// 
			// lb_ip
			// 
			this.lb_ip.AutoSize = true;
			this.lb_ip.Location = new System.Drawing.Point(25, 19);
			this.lb_ip.Name = "lb_ip";
			this.lb_ip.Size = new System.Drawing.Size(24, 12);
			this.lb_ip.TabIndex = 0;
			this.lb_ip.Text = "IP :";
			// 
			// richtb_message
			// 
			this.richtb_message.Location = new System.Drawing.Point(0, 28);
			this.richtb_message.Name = "richtb_message";
			this.richtb_message.Size = new System.Drawing.Size(263, 244);
			this.richtb_message.TabIndex = 5;
			this.richtb_message.Text = "";
			// 
			// Form_Message
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 370);
			this.Controls.Add(this.panel_setup);
			this.Controls.Add(this.richtb_message);
			this.Controls.Add(this.panel_message);
			this.Controls.Add(this.toolStrip_bar);
			this.Controls.Add(this.statusStrip_bar);
			this.Name = "Form_Message";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Message_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip_bar.ResumeLayout(false);
			this.statusStrip_bar.PerformLayout();
			this.toolStrip_bar.ResumeLayout(false);
			this.toolStrip_bar.PerformLayout();
			this.panel_message.ResumeLayout(false);
			this.panel_message.PerformLayout();
			this.panel_setup.ResumeLayout(false);
			this.panel_setup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip_bar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_lb_time;
		private System.Windows.Forms.ToolStrip toolStrip_bar;
		private System.Windows.Forms.ToolStripButton toolStripBtn_connect;
		private System.Windows.Forms.ToolStripButton toolStripBtn_disconnect;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
		private System.Windows.Forms.Panel panel_message;
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.TextBox tb_message;
		private System.Windows.Forms.Panel panel_setup;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_setup;
		private System.Windows.Forms.CheckBox cb_server;
		private System.Windows.Forms.TextBox tb_ip;
		private System.Windows.Forms.TextBox tb_port;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Label lb_port;
		private System.Windows.Forms.Label lb_id;
		private System.Windows.Forms.Label lb_ip;
		private System.Windows.Forms.RichTextBox richtb_message;
	}
}

