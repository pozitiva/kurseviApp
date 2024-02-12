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

        public List<Predavac> VratiSvePredavace()
        {
            VratiSvePredavaceSO operacija = new VratiSvePredavaceSO();
            return (List<Predavac>)operacija.IzvrsiSO(new Predavac());  
        }

        public bool KreirajKurs(Kurs k)
        {
            KreirajKursSO operacija = new KreirajKursSO();
            return (bool)operacija.IzvrsiSO(k);
        }

        public List<Kurs> VratiSveKurseve()
        {
            VratiSveKurseveSO operacija = new VratiSveKurseveSO();
            return (List<Kurs>)operacija.IzvrsiSO(new Kurs());
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
            return (List<Ucenik>)operacija.IzvrsiSO(new Ucenik());
        }

       public List<Ucenik> PretraziUcenike(Ucenik u)
        {
            PretraziUcenikeSO operacija = new PretraziUcenikeSO();
            return (List<Ucenik>)operacija.IzvrsiSO(u);
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

        public bool KreirajGrupu(Grupa g)
        {
            KreirajGrupuSO operacija = new KreirajGrupuSO();
            return (bool)operacija.IzvrsiSO(g);
        }

        public List<Grupa> VratiSveGrupe()
        {
            VratiSveGrupeSO operacija = new VratiSveGrupeSO();
            return (List<Grupa>)operacija.IzvrsiSO(new Grupa());
        }

        public List<Grupa> PretraziGrupe(Grupa grupa)
        {
            PretraziGrupeSO operacija = new PretraziGrupeSO();
            return (List<Grupa>)operacija.IzvrsiSO(grupa);
        }

        public Grupa VratiGrupu(Grupa grupa)
        {
            VratiGrupuSO operacija = new VratiGrupuSO();
            return (Grupa)operacija.IzvrsiSO(grupa);
        }

        public bool IzmeniGrupu(Grupa grupa)
        {
            IzmeniGrupuSO operacija = new IzmeniGrupuSO();
            return (bool)operacija.IzvrsiSO(grupa);
        }

        public Zaposleni UlogujSe(Zaposleni zaposleni)
        {
            PrijaviSeSO operacija = new PrijaviSeSO();
            return (Zaposleni)operacija.IzvrsiSO(zaposleni);
        }
    }
}
