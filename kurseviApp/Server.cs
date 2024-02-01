using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kurseviApp
{
    public class Server
    {
        private Socket serverskiSocket;
        static List<NitKlijenta> klijenti = new List<NitKlijenta>();
        public void Pokreni()
        {
            serverskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            serverskiSocket.Bind(endPoint);
            serverskiSocket.Listen(10);
            Osluskuj();
        }

        public void Osluskuj()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSocket = serverskiSocket.Accept();
                    NitKlijenta klijent = new NitKlijenta(klijentskiSocket);
                    klijenti.Add(klijent);

                    Thread nit = new Thread(klijent.ObradiZahteve);
                    nit.IsBackground = true;
                    nit.Start();
                }
            }
            catch (IOException e)
            {
                serverskiSocket.Close();
                Debug.WriteLine(e.Message);
            }
            catch (SocketException e)
            {
                serverskiSocket.Close();
                Debug.WriteLine(e.Message);

            }
        }

        public void Prekini()
        {
             serverskiSocket.Close();
             klijenti.Clear();

        }
    }
}
