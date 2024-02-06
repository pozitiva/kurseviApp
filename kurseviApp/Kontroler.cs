using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Kontroler
    {
        private static Kontroler instance;
        public static Kontroler Instance { 
            get { 
                if(instance == null)
                    instance = new Kontroler();
                return instance; 
            } 
        }

        public List<Zaposleni> VratiSveZaposlene()
        {
            VratiSveZaposleneSO operacija = new VratiSveZaposleneSO();
            List<Zaposleni> zaposleni = (List<Zaposleni>)operacija.IzvrsiSO(new Zaposleni());
            return zaposleni;
        }

        public List<Predavac> VratiSvePredavace()
        {
            VratiSvePredavaceSO operacija = new VratiSvePredavaceSO();
            List<Predavac> predavaci = (List<Predavac>)operacija.IzvrsiSO(new Predavac());  
            return predavaci;
        }

        public bool KreirajKurs(Kurs k)
        {
            KreirajKursSO operacija = new KreirajKursSO();
            return (bool)operacija.IzvrsiSO(k);
        }

        public List<Kurs> VratiSveKurseve()
        {
            VratiSveKurseveSO operacija = new VratiSveKurseveSO();
            List<Kurs> kursevi = (List<Kurs>)operacija.IzvrsiSO(new Kurs());
            return kursevi;
        }

        public List<Kurs> PretraziKurseve(Kurs k)
        {
            PretraziKurseveSO operacija = new PretraziKurseveSO();
            List<Kurs> kursevi = (List<Kurs>)operacija.IzvrsiSO(k);
            return kursevi;
        }

        public Kurs VratiKurs(Kurs k)
        {
            VratiKursSO operacija = new VratiKursSO();
            return (Kurs)operacija.IzvrsiSO(k);
        }

        public bool IzmeniKurs(Kurs k)
        {
            IzmeniKursSO operacija = new IzmeniKursSO();
            return (bool)operacija.IzvrsiSO(k);
        }

        public bool ObrisiKurs(Kurs k)
        {
            ObrisiKursSO operacija = new ObrisiKursSO();
            return (bool)operacija.IzvrsiSO(k);
        }

        public bool KreirajUcenika(Ucenik u)
        {
            KreirajUcenikaSO operacija = new KreirajUcenikaSO();
            return (bool)operacija.IzvrsiSO(u);
        }

        public List<Ucenik> VratiSveUcenike()
        {
            VratiSveUcenikeSO operacija = new VratiSveUcenikeSO();
            List<Ucenik> ucenici = (List<Ucenik>)operacija.IzvrsiSO(new Ucenik());
            return ucenici;
        }

       public List<Ucenik> PretraziUcenike(Ucenik u)
        {
            PretraziUcenikeSO operacija = new PretraziUcenikeSO();
            List<Ucenik> ucenici = (List<Ucenik>)operacija.IzvrsiSO(u);
            return ucenici;
        }

       public Ucenik VratiUcenika(Ucenik u)
       {
            VratiUcenikaSO operacija = new VratiUcenikaSO();
            return (Ucenik)operacija.IzvrsiSO(u);
       }

        public bool IzmeniUcenika(Ucenik u)
        {
            IzmeniUcenikaSO operacija = new IzmeniUcenikaSO();
            return (bool)operacija.IzvrsiSO(u);
        }

        public bool ObrisiUcenika(Ucenik u)
        {
            ObrisiUcenikaSO operacija = new ObrisiUcenikaSO();
            return (bool)operacija.IzvrsiSO(u);
        }
    }
}
