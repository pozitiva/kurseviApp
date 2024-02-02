using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSvePredavaceSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            List<Predavac> predavaci = broker.Vrati(domenskiObjekat).OfType<Predavac>().ToList();
            return predavaci;
        
        }
    }
}
