using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public static Lobby lobby;
        public Login()
        {
            InitializeComponent();
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            ClientSocket.Connect();
            lobby = new Lobby();
            
            this.Hide();
        }
        private void btn_join_Click(object sender, EventArgs e)
        {
            ClientSocket.Connect();
            
            ShowDialog();
            this.Hide();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Send()
        {
            
        }

       
    }
}
