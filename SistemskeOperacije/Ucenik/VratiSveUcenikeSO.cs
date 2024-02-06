using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSveUcenikeSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            List<Ucenik> ucenici = broker.VratiSve(domenskiObjekat).OfType<Ucenik>().ToList();
            return ucenici;
        }
    }
}
