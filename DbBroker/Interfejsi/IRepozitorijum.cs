using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public interface IRepozitorijum<TDomenskiObjekat> where TDomenskiObjekat : class
    {
        int Sacuvaj(TDomenskiObjekat domenskiObjekat);
        int Izmeni(TDomenskiObjekat domenskiObjekat);
        int Obrisi(TDomenskiObjekat domenskiObjekat);
        TDomenskiObjekat Vrati(TDomenskiObjekat domenskiObjekat);
        List<TDomenskiObjekat> VratiSve(TDomenskiObjekat domenskiObjekat);
        List<TDomenskiObjekat> Pretrazi(TDomenskiObjekat domenskiObjekat);
    }
}
