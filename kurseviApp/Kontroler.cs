﻿using Domen;
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

        public bool KreirajKurs(Kurs kurs)
        {
            KreirajKursSO operacija = new KreirajKursSO();
            return (bool)operacija.IzvrsiSO(kurs);
        }

        public List<Kurs> VratiSveKurseve()
        {
            VratiSveKurseveSO operacija = new VratiSveKurseveSO();
            List<Kurs> kursevi = (List<Kurs>)operacija.IzvrsiSO(new Kurs());
            return kursevi;
        }

        public List<Kurs> PretraziKurseve(Kurs kurs)
        {
            PretraziKurseveSO operacija = new PretraziKurseveSO();
            List<Kurs> kursevi = (List<Kurs>)operacija.IzvrsiSO(kurs);
            return kursevi;
        }

        public Kurs VratiKurs(Kurs k)
        {
            VratiKursSO operacija = new VratiKursSO();
            Kurs kurs = (Kurs)operacija.IzvrsiSO(k);
            return kurs;
        }
    }
}
