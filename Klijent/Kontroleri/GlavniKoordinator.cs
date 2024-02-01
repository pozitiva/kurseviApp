using Domen;
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

        //kontroleri
        public KursKontroler kursKontroler;


        private static GlavniKoordinator instance;
        public static GlavniKoordinator Instance
        {
            get {
                if (instance == null)
                    instance = new GlavniKoordinator();
                return instance;
            }
        }

        public GlavniKoordinator()
        {
            kursKontroler = new KursKontroler();
        }

        public void PrikaziKreirajKurs()
        {
            
        }
    }
}
