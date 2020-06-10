using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32; //레지스트리 클래스 사용
using System.Net; // IPAddress
using System.Net.Sockets; //TcpListener 클래스 사용
using System.Threading; //스레드 클래스 사용
using System.IO; //파일 클래스 사용. stream
using System.Runtime.InteropServices; //작업표시줄 폼 깜빡임 구현

namespace Socket_Message
{
	public partial class Form_Message : Form
	{
		public Form_Message()
		{
			InitializeComponent();
		}
		private RegistryKey regkey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework", true); //레지스트리 쓰기, 읽기
		private string myID;
		private int myPort;
		private delegate void AddTextDelegate(string strText);
		private AddTextDelegate AddText = null;
		private TcpListener Server; //TCP 네트워크 클라이언트에서 연결 수신
		private TcpClient serClient, Client; //TCP 네트워크 서비스에 대한 클라이언트 연결 제공
		private Thread threadServer, threadReader;
		private NetworkStream myStream; //네트워크 스트림
		private StreamReader myRead; //스트림 읽기
		private StreamWriter myWrite; //스트림 쓰기
		private Boolean sStart = false; //서버 시작
		private Boolean cStart = false;//클라이언트 시작 
		private Boolean textChange = false;
		private Boolean textSend = false;

		//작업표시줄 폼 깜빡임
		[DllImport("User32.dll")]
		private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

		private void Form1_Load(object sender, EventArgs e)
		{
			if ((string)regkey.GetValue("Message_id") == "")
			{
				this.myID = this.tb_id.Text;
				this.myPort = 62000;
			}
			else
			{
				try
				{
					this.myID = (string)regkey.GetValue("Message_id");
					this.myPort = 62000;
				}
				catch
				{
					this.myID = this.tb_id.Text;
					this.myPort = 62000;
				}
			}
			this.tb_port.Text = "62000";
		}
		private void Form_Message_FormClosing(object sender, FormClosingEventArgs e)
		{
			try { ServerStop(); }
			catch { Disconnection(); }
		}

		private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.설정ToolStripMenuItem.Enabled = false;
			this.panel_setup.Visible = true;
			this.tb_id.Focus();
			this.tb_id.Text = (string)regkey.GetValue("Message_id");
			this.tb_port.Text = "62000";
		}
		private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btn_setup_Click(object sender, EventArgs e)
		{
			if (this.cb_server.Checked == true) //서버 모드 전환
			{
				ControlCheck();
			}
			else // 클라이언트 실행
			{
				if (this.tb_ip.Text == "")
				{
					this.tb_ip.Focus();
				}
				else
				{
					ControlCheck();
				}
			}
		}
		private void cb_server_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cb_server.Checked)
			{
				this.tb_ip.Enabled = false; //서버 모드 전환			
			}
			else 
			{
				this.tb_ip.Enabled = true; //클라이언트 모드 전환
			}
		}
		private void btn_close_Click(object sender, EventArgs e)
		{
			this.설정ToolStripMenuItem.Enabled = true; //설정 메뉴 활성화
			this.panel_setup.Visible = false; //입력창 닫기
			this.tb_message.Focus();
		}
		private void toolStripBtn_connect_Click(object sender, EventArgs e)
		{
			AddText = new AddTextDelegate(MessageView);
			if (this.cb_server.Checked == true)
			{
				var addr = new IPAddress(0);
				try
				{
					this.myID = (string)regkey.GetValue("Message_id");
				}
				catch
				{
					this.myID = this.tb_id.Text;
					this.myPort = Convert.ToInt32(this.tb_port.Text);
				}

				if (!(this.sStart))
				{
					try
					{
						Server = new TcpListener(addr, this.myPort);
						Server.Start();

						this.sStart = true;
						this.tb_message.Enabled = true;
						this.btn_send.Enabled = true;
						this.tb_message.Focus();
						this.toolStripBtn_disconnect.Enabled = true;
						this.toolStripBtn_connect.Enabled = false;
						this.cb_server.Enabled = false;

						threadServer = new Thread(ServerStart);
						threadServer.Start();
						this.설정ToolStripMenuItem.Enabled = false;
					}
					catch
					{
						Invoke(AddText, "서버를 실행할 수 없습니다.");
					}
				}
				else
				{
					ServerStop();
				}
			}
			else
			{
				if (!(this.cStart))
				{
					this.myID = (string)regkey.GetValue("Message_id");
					this.myPort = Convert.ToInt32(regkey.GetValue("Message_port"));
					ClientConnection();
				}
				else
				{
					this.tb_message.Enabled = false;
					this.btn_send.Enabled = false;
					Disconnection();
				}
			}
		}
		 

		private void ControlCheck()
		{
			if (this.tb_id.Text == "")
			{
				this.tb_id.Focus();
			}
			else if (this.tb_port.Text == "")
			{
				this.tb_port.Focus();
			}
			else
			{
				try 
				{
					var name = this.tb_id.Text;
					var port = this.tb_port.Text;
					regkey.SetValue("Message_id", name);
					regkey.SetValue("Message_port", port);
					this.panel_setup.Visible = false;
					this.설정ToolStripMenuItem.Enabled = true;
					this.toolStripBtn_connect.Enabled = true;
				}
				catch 
				{
					MessageBox.Show("설정이 저장되지 않았습니다", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			
			}

		}		
		
		
		private void MessageView(string strText)
		{
			this.richtb_message.AppendText(strText + "\r\n");
			this.richtb_message.Focus();
			this.richtb_message.ScrollToCaret();
			this.tb_message.Focus();					
		}
		private void ServerStart()
		{
			Invoke(AddText, "서버 실행 : 상대방 접속을 기다립니다...");
			while(sStart)
			{
				try
				{
					Client = Server.AcceptTcpClient(); //클라이언트 연결 요청 수락
					Invoke(AddText, "상대방이 접속하였습니다.");
					myStream = Client.GetStream();

					myRead = new StreamReader(myStream);
					myWrite = new StreamWriter(myStream);
					this.cStart = true;
					threadReader = new Thread(Receive);
					threadReader.Start();
				}
				catch { }
			}			
		}

		

		private void Receive()
		{
			try
			{
				while (this.cStart)
				{
					Thread.Sleep(1);
					if (myStream.CanRead)
					{
						var msg = myRead.ReadLine();
						var Smsg = msg.Split('&');
						if (Smsg[0] == "S001")
						{
							this.toolStripStatus_lb_time.Text = Smsg[1];
						}
						else
						{
							if (msg.Length > 0)
							{
								Invoke(AddText, Smsg[0] + " : " + Smsg[1]);
							}
							this.toolStripStatus_lb_time.Text = "마지막으로 받은 시각:" + Smsg[2];
						}

					}
				}
			}
			catch { }
		
		}
		private void ServerStop()
		{
			this.sStart = false;
			this.tb_message.Enabled = false;
			this.tb_message.Clear();
			this.btn_send.Enabled = false;
			this.toolStripBtn_connect.Enabled = true;
			this.toolStripBtn_disconnect.Enabled = false;
			this.cb_server.Enabled = true;
			this.cStart = false;

			if (!(myRead == null))
			{
				myRead.Close(); //StreamReader 클래스 개체 리소스 해제
			}
			if (!(myWrite == null))
			{
				myWrite.Close(); //StreamWriter 클래스 개체 리소스 해제
			}
			if (!(myStream == null))
			{
				myStream.Close(); //NetworkStream 클래스 개체 리소스 해제
			}
			if (!(Client == null))
			{
				Client.Close(); //TcpClient 클래스 개체 리소스 해제
			}
			if (!(Server == null))
			{
				Server.Stop(); //TcpListen 클래스 개체 리소스 해제
			}
			if (!(threadReader == null))
			{
				threadReader.Abort(); //외부 스레드 종료
			}
			if (!(threadServer == null))
			{
				threadServer.Abort(); //외부 스레드 종료
			}
			if (!(AddText == null))
			{
				Invoke(AddText, "연결이 끊어졌습니다.");
			}
		}
	}
}
