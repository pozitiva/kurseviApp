using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Komunikacija
{
    public class Primalac
    {

        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        public Primalac(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }
        public T Receive<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }

    }
}
