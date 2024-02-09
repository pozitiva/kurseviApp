using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSveGrupeSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            return broker.VratiSve(domenskiObjekat).OfType<Grupa>().ToList();

        }
    }
}
