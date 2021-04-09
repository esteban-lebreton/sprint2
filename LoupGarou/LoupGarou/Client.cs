using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Client
    {
        private Socket leSocket;
        private IPEndPoint leIPEP;
        private TextReader leTR;
        private TextWriter leTW;
        private string lAdresseS;
        private string lAdresseC;
        private int lePortS;
        private Plateforme laPlateforme;
        private string leLogin;
        private Thread leThread;
        public int numero;

        public Client(int num)
        {
            this.numero = num;
        }
        public Client (string adresseS, int portS, string login)
        {
            leSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            leIPEP = new IPEndPoint(IPAddress.Parse(adresseS), portS);
            leSocket.Connect(leIPEP);
        }

        public void Run()
        {
            NetworkStream leNS = new NetworkStream(leSocket);
            leTR = new StreamReader(leNS);
            leTW = new StreamWriter(leNS);

            leThread = new Thread(EcouteReponse);
            leThread.Start();
        }

        public void EcouteReponse()
        {
            while (true)
            {
                string leMessageObtenu = leTR.ReadLine();
                leTW.WriteLine("Le message obtenu est : " + leMessageObtenu);
                leTW.Flush();
            }
        }
    }
}
