using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class IzmeniGrupuSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            bool signal= broker.Izmeni(domenskiObjekat)>0;
            
            Grupa grupa = (Grupa)domenskiObjekat;
            //List<PripadanjeGrupi> pripadanja = ((Grupa)domenskiObjekat).Pripadanja;
            //foreach (PripadanjeGrupi pg in pripadanja)
            //{
            //    pg.Grupa = grupa;

            //    signal = signal && broker.Obrisi(pg) > 0;
            //}

            List<PripadanjeGrupi> pripadanja = ((Grupa)domenskiObjekat).Pripadanja;
            foreach (PripadanjeGrupi pg in pripadanja)
            {
                pg.Grupa = grupa;

                signal = signal && broker.Sacuvaj(pg) > 0;
            }

            return signal;



        }
    }
}
