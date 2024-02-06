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
        public UcenikKontroler ucenikKontroler;

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
            ucenikKontroler = new UcenikKontroler();
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

        public void PrikaziKreirajUcenika()
        {
            frmZaposleni.PromeniPanel(ucenikKontroler.KreirajUcUpravljajUcenikom(FormMode.Dodaj, null));
        }
        public void PrikaziIzmeniUcenike()
        {
            frmZaposleni.PromeniPanel(ucenikKontroler.KreirajUcPrikaziUcenike(FormMode.Izmeni));
        }

        public void PrikaziSveUcenike()
        {
            frmZaposleni.PromeniPanel(ucenikKontroler.KreirajUcPrikaziUcenike(FormMode.Prikazi));
        }

        public void PrikaziObirsiUcenika()
        {
            frmZaposleni.PromeniPanel(ucenikKontroler.KreirajUcPrikaziUcenike(FormMode.Obrisi));
        }

        public void PrikaziUcenikaZaIzmenu(Ucenik u)
        {
            frmZaposleni.PromeniPanel(ucenikKontroler.KreirajUcUpravljajUcenikom(FormMode.Izmeni, u));

        }

        public void PrikaziUcenikaZaBrisanje(Ucenik u)
        {
            frmZaposleni.PromeniPanel(ucenikKontroler.KreirajUcUpravljajUcenikom(FormMode.Obrisi, u));  
        }
    }
}
