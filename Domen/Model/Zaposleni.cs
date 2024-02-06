using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Zaposleni : DomenskiObjekat
    {
        public string KorisnickoIme {  get; set; }
        public string Sifra {  get; set; }

        [Browsable(false)]
        public string NazivTabele => "Zaposleni";

        [Browsable(false)]
        public string VrednostiZaUnos => $"'{KorisnickoIme}', '{Sifra}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";
        
        [Browsable(false)]
        public string Join => string.Empty;

        [Browsable(false)]
        public string KriterijumPretrage { get; set; }

        [Browsable(false)]
        public string VrednostiZaIzmenu => "";

        [Browsable(false)]
        public string UslovObrade => "";

        [Browsable(false)]
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> zaposleni = new List<DomenskiObjekat> ();

            while (reader.Read())
            {
                Zaposleni zaposlen = new Zaposleni() {

                    KorisnickoIme = reader.GetString(0),
                    Sifra = reader.GetString(1)
                };

                zaposleni.Add (zaposlen);   
            }
            return zaposleni;
        }

        public override string ToString()
        {
            return KorisnickoIme;
        }
    }
}