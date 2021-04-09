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
    public class Server
    {
        public Plateforme laPlateforme;
        public string lAdresseS;
        public int lePortS;
        public Socket leSocket;
        public TextReader leMessageObtenu;
        public TextWriter leMessageAEnvoyer;
        public int nbreClient = 0;
        public int laCapacite;
        public ClientCommunication laCom;

        public Server(Plateforme laPlateforme, string lAdresseS, int lePortS, int laCapacite = 6)
        {
            this.laPlateforme = laPlateforme;
            this.lePortS = lePortS;
            this.laCapacite = laCapacite;
            leSocket = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("0.0.0.0"), this.lePortS);
            leSocket.Bind(iep);
            leSocket.Listen(1);
        }

        public void Run()
        {
            while (true)
            {
                nbreClient++;
                Socket leSocketAcep = leSocket.Accept();
                laCom = new ClientCommunication(leSocketAcep, nbreClient, this);
                Thread _thread = new Thread(Communication);
                _thread.Start(laCom);
            }
        }

        public void Communication(object o)
        {
            laCom = o as ClientCommunication;
            NetworkStream _Network = new NetworkStream(laCom.leSocket);
            leMessageObtenu = new StreamReader(_Network);
            leMessageAEnvoyer = new StreamWriter(_Network);
            string ipport = laCom.leSocket.RemoteEndPoint.ToString();
            while (true)
            {
                setText("Client n. :" + nbreClient + " avec l'adresse " + ipport);
            }
        }

        public string getText()
        {
            return leMessageObtenu.ReadLine();
        }

        public void setText(string leMessage)
        {
            leMessageAEnvoyer.WriteLine(leMessage);
            leMessageAEnvoyer.Flush();
        }
    }
}