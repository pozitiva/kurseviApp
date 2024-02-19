using Domen;
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
using System.Windows.Forms;

namespace kurseviApp
{
    public class Server
    {
        private Socket serverskiSocket;
        public bool pokrenutServer = false;
        static List<NitKlijenta> klijenti = new List<NitKlijenta>();
        private static Server instance;
        public static Server Instance
        {
            get { 
                if(instance == null)
                    instance = new Server();
                return instance; 
            }
        }
        public void Pokreni()
        {
            try
            {
                serverskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(ConfigurationManager.AppSettings["port"]));
                serverskiSocket.Bind(endPoint);
                serverskiSocket.Listen(10);

                pokrenutServer = true;

                Thread nit = new Thread(Osluskuj);
                nit.IsBackground = true;
                nit.Start();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public void Osluskuj()
        {
            try
            {
                while (pokrenutServer)
                {
                    Socket klijentskiSocket = serverskiSocket.Accept();
                    NitKlijenta klijent = new NitKlijenta(klijentskiSocket);
                    klijenti.Add(klijent);

                    Thread nit = new Thread(klijent.ObradiZahteve);
                    nit.IsBackground = true;
                    nit.Start();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Server je prekinut");
            }

        }

        public void Prekini()
        {
            try
            {
                serverskiSocket.Close();
                pokrenutServer = false;

                foreach (NitKlijenta klijent in klijenti)
                {
                    klijent.ZatvoriSocket();
                }

                klijenti.Clear();
            }catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message);
            }

        }
    }
}
