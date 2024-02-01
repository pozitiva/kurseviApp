using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Kontroler
    {
        private static Kontroler instance;
        public static Kontroler Instance { 
            get { 
                if(instance == null)
                    instance = new Kontroler();
                return instance; 
            } 
        }

        public List<Zaposleni> VratiSveZaposlene()
        {
            VratiSveZaposleneSO operacija = new VratiSveZaposleneSO();
            List<Zaposleni> zaposleni = (List<Zaposleni>)operacija.IzvrsiSO(new Zaposleni());

            return zaposleni;
        }
    }
}
