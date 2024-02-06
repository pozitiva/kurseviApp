using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija {  get; set; }
        public Zaposleni Zaposleni { get; set; }
        public Kurs Kurs { get; set; }
        public Ucenik Ucenik { get; set; }
    }
}
