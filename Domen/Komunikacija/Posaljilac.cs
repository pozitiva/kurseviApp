using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Posaljilac
    {

        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        public Posaljilac(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }
        public void Posalji(object argument)
        {
            formatter.Serialize(stream, argument);
        }
    }
}
