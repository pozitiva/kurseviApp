using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSveKurseveSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            List<Kurs> kursevi = broker.VratiSve(domenskiObjekat).OfType<Kurs>().ToList();
            return kursevi;
        }
    }
}
