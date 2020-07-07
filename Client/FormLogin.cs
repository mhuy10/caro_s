using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        Socket TCPclient;
        IPEndPoint ipe;
        bool daketnoi = false;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnvaogame_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            try
            {
                
                TCPclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                
                try
                {
                    
                    // kết nối socket đến remove endpoint ( localhost sever )
                    ipe = new IPEndPoint(IPAddress.Parse(txip.Text), 9124);
                    TCPclient.Connect(ipe);
                    daketnoi = true;
                    
                }
                catch { }
                
                if (!daketnoi)
                {
                    MessageBox.Show("Không tìm thấy server");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy server");
                Application.Exit();
            }

            
                if (txtusername.Text == string.Empty)
                {
                    MessageBox.Show("Username is not empty!");
                }
                else
                {
                    byte[] data = new byte[1024];
                    data = Encoding.UTF8.GetBytes("NAMECLIENT|," + txtusername.Text + ",");
                    TCPclient.Send(data, data.Length, SocketFlags.None);


                    FormGame frm = new FormGame();
                    frm.username = txtusername.Text;
                    frm.client = TCPclient;
                    frm.Show();
                    this.Hide();

                }
            
        }
    }
}
