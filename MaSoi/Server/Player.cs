using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Player
    {
        public string Name { get; set; }
        public Socket playerSocket { get; set; }
        public bool isHost { get; set; }
    }
}
