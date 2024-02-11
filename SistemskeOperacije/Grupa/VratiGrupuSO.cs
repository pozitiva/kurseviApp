using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiGrupuSO : OpstaSistemskaOperacija
    {
        protected override object Izvrsavanje(DomenskiObjekat domenskiObjekat)
        {
            Grupa grupa = (Grupa)repozitorijum.Vrati(domenskiObjekat);
            PripadanjeGrupi pripadanje = new PripadanjeGrupi
            {
                KriterijumPretrage = $"pripadanjegrupi.idgrupe='{grupa.IDGrupe}'",
                Grupa = grupa,
               
            };
            BindingList<PripadanjeGrupi> pripadanja = new BindingList<PripadanjeGrupi>(repozitorijum.Pretrazi(pripadanje).Cast<PripadanjeGrupi>().ToList());

            grupa.Pripadanja = pripadanja;

            return grupa;
        }
    }
}
