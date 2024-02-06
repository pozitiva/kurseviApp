using Domen;
using Klijent.Forme;
using Klijent.KorisnickeKontrole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Kontroleri
{
    internal class GlavniKoordinator
    {
        public Zaposleni ulogovaniZaposleni;

        //forme 
        public FrmPrijavljivanje frmPrijavljivanje;
        public FrmZaposleni frmZaposleni;

        //kontroleri
        public ZaposleniKontroler zaposleniKontroler;
        public KursKontroler kursKontroler;


        private static GlavniKoordinator instance;
        public static GlavniKoordinator Instance
        {
            get
            {
                if (instance == null)
                    instance = new GlavniKoordinator();
                return instance;
            }
        }

        public GlavniKoordinator()
        {
            zaposleniKontroler = new ZaposleniKontroler();
            kursKontroler = new KursKontroler();
        }

        #region prijava
        public void KreirajPrijavu()
        {
            zaposleniKontroler.KreirajFrmPrijavljivanje(this.frmPrijavljivanje);
        }

        public void PrikaziFrmZaposleni()
        {
            frmPrijavljivanje.Visible = false;
            frmZaposleni = new FrmZaposleni(ulogovaniZaposleni);
            frmZaposleni.ShowDialog();
            frmPrijavljivanje.Visible = true;
        }

        #endregion
        public void PrikaziKreirajKurs()
        {
            frmZaposleni.PromeniPanel(kursKontroler.KreirajUcUpravljajKurs(FormMode.Dodaj, null));
        }

        public void PrikaziSveKurseve()
        {
            frmZaposleni.PromeniPanel(kursKontroler.KreirajUcPrikaziKurseve(FormMode.Prikazi));
        }

        public void PrikaziPodatkeOKursu(Kurs k)
        {
            frmZaposleni.PromeniPanel(kursKontroler.KreirajUcUpravljajKurs(FormMode.Prikazi ,k));
        }

        public void PrikaziIzmeniKurs()
        {
            frmZaposleni.PromeniPanel(kursKontroler.KreirajUcPrikaziKurseve(FormMode.Izmeni));
        }

        public void PrikaziKursZaIzmenu(Kurs k)
        {
            frmZaposleni.PromeniPanel(kursKontroler.KreirajUcUpravljajKurs(FormMode.Izmeni,k));
        }

        public void PrikaziObrisiKurs()
        {
            frmZaposleni.PromeniPanel(kursKontroler.KreirajUcPrikaziKurseve(FormMode.Obrisi));
        }

        public void PrikaziKursZaBrisanje(Kurs k)
        {
            frmZaposleni.PromeniPanel(kursKontroler.KreirajUcUpravljajKurs(FormMode.Obrisi,k));
        }
    }
}
