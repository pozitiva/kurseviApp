using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Predavac : DomenskiObjekat
    {
        [Browsable(false)]
        public int IDPredavaca { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        [Browsable(false)]
        public string NazivTabele => "Predavac";
        
        [Browsable(false)]
        public string VrednostiZaUnos => $"'{IDPredavaca}', '{Ime}', '{Prezime}', '{DatumRodjenja}' ";
        
        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => string.Empty;

        [Browsable(false)]
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> predavaci = new List<DomenskiObjekat> ();
            while(reader.Read ()) {

                Predavac predavac = new Predavac()
                {
                    IDPredavaca = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    DatumRodjenja = reader.GetDateTime(3)
                };
                predavaci.Add(predavac);

            }
            return predavaci;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}