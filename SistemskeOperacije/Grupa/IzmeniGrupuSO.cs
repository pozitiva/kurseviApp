using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            foreach(PripadanjeGrupi pg in grupa.IzbacenaPripadanja)
            {
                pg.Grupa = grupa;
                signal = signal && broker.Obrisi(pg)>0;
            }

            PripadanjeGrupi pripadanje = new PripadanjeGrupi
            {
                KriterijumPretrage = $"pripadanjegrupi.idgrupe='{grupa.IDGrupe}'",
                Grupa = grupa,

            };
            BindingList<PripadanjeGrupi> staraPripadanja = new BindingList<PripadanjeGrupi>(broker.Pretrazi(pripadanje).Cast<PripadanjeGrupi>().ToList());

            BindingList<PripadanjeGrupi> novaPripadanja = ((Grupa)domenskiObjekat).Pripadanja;
            for (int i = staraPripadanja.Count;i<novaPripadanja.Count ;i++)
            {
                novaPripadanja[i].Grupa = grupa;

                signal = signal && broker.Sacuvaj(novaPripadanja[i]) > 0;
            }

            return signal;



        }
    }
}
