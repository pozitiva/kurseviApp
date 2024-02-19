using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ObrisiKursSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            try
            {
                return broker.Obrisi(domenskiObjekat)>0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
