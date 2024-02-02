using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class KorisnickaGreska:Exception
    {
        public string Poruka {  get; set; }

        public KorisnickaGreska(string message)
        {
            Poruka = message;
        }
    }
}
