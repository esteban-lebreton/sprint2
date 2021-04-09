using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class ClientCommunication
    {
        public Socket leSocket;
        public int nbreClient;
        public Server leServer;

        public ClientCommunication(Socket leSocket, int nbreClient, Server leServer)
        {
            this.leSocket = leSocket;
            this.nbreClient = nbreClient;
            this.leServer = leServer;
        }
    }
}
