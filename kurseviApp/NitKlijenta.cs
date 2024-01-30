using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace kurseviApp
{
    public class NitKlijenta
    {
        private Socket klijentskiSocket;
        private BinaryFormatter formatter = new BinaryFormatter();
        private NetworkStream stream;

        public NitKlijenta(Socket klijentskiSocket)
        {
            this.klijentskiSocket = klijentskiSocket;
            stream = new NetworkStream(klijentskiSocket);
        }

        public void ObradiZahteve()
        {
            while (true)
            {
                try
                {

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
