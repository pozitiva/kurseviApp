using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiKursSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            Kurs kurs = (Kurs)domenskiObjekat;
            return (Kurs)broker.Vrati(new Kurs(), $"idkursa='{kurs.IDKursa}'");
        }
    }
}
