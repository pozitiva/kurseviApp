using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSveZaposleneSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            List<Zaposleni> zaposleni = broker.VratiSve(domenskiObjekat).OfType<Zaposleni>().ToList(); 
            return zaposleni;
        }
    }
}
