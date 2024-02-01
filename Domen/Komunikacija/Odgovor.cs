using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{ 
    [Serializable]
    public class Odgovor
    {
        public Signal Signal { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public bool Uspesno { get; set; }
        public string Poruka { get; set; }
        public Exception Greska { get; set; }
    }

    public enum Signal
    {
        NeuspesnaPrijava,
        UspesnaPrijava
    }
}
