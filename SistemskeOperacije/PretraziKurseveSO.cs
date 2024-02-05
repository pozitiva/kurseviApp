using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PretraziKurseveSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            return broker.Pretrazi(domenskiObjekat, domenskiObjekat.UslovObrade).Cast<Kurs>().ToList();
        }
    }
}
