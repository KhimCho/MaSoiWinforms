using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client
{
    public partial class Lobby : Form
    {
        public Lobby lobby;
        public List<Label> PlayerName = new List<Label>();
        public int connectedPlayer = 0;
        public Lobby()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            lobby = this;
            btn_Start.Visible = false;
            
        }

        public void ShowStartButton()
        {
            btn_Start.Visible = true;
        }
        private void btn_Send_Click(object Sender, EventArgs e)
        {
            
        }
        private void btn_Start_Click(object Sender, EventArgs e)
        {
            ClientSocket.datatype = "START";
        }
        private void btn_Exit_Click(object Sender, EventArgs e)
        {
            Close();
        }
    }
}