using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Ucenik : DomenskiObjekat
    {
        [Browsable(false)]
        public int IDUcenika { get; set; }
        public string Ime {  get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Zaposleni Zaposleni { get; set; }

        [Browsable (false)]
        public string NazivTabele => "Ucenik";

        [Browsable(false)]
        public string VrednostiZaUnos => $"'{IDUcenika}', '{Ime}', '{Prezime}', '{DatumRodjenja}', '{Zaposleni.KorisnickoIme}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => "join zaposleni z on z.koriscnikoime= kurs.korisnickoime";

        [Browsable(false)]
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> ucenici = new List<DomenskiObjekat> ();
            while(reader.Read ())
            {
                Ucenik ucenik = new Ucenik()
                {
                    IDUcenika = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    DatumRodjenja = reader.GetDateTime(3),
                    Zaposleni = new Zaposleni()
                    {
                        KorisnickoIme = reader.GetString(4),
                        Sifra = reader.GetString(6)
                    }
                };

                ucenici.Add(ucenik);

            }
            return ucenici;
        }
    }
}
