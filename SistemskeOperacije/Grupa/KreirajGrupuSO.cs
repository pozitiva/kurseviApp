using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class KreirajGrupuSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            bool signal = broker.Sacuvaj((Grupa)domenskiObjekat)>0;

            List<Grupa> grupe = broker.VratiSve(domenskiObjekat).OfType<Grupa>().ToList();
            Grupa grupa = grupe[grupe.Count - 1];

            BindingList<PripadanjeGrupi> pripadanja = ((Grupa)domenskiObjekat).Pripadanja;
            foreach (PripadanjeGrupi pg in pripadanja)
            {
                pg.Grupa = grupa;

                signal = signal && broker.Sacuvaj(pg)>0;
            }

            return signal;
        }
    }
}
