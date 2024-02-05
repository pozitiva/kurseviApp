using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{ 
    [Serializable]
    public class Odgovor
    {
        public Operacija Operacija { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public List<Predavac> Predavaci { get; set; }
        public List<Kurs> Kursevi { get; set; }
        public Kurs Kurs { get; set; }
        public bool Uspesno { get; set; }
        public string Poruka { get; set; }
        public Exception Greska { get; set; }
    }

}
