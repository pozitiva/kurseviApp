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
        public string VrednostiZaUnos => $"'{Ime}', '{Prezime}', '{DatumRodjenja.ToString("MM/dd/yyyy")}', '{Zaposleni.KorisnickoIme}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => "join zaposleni z on z.korisnickoime= ucenik.korisnickoime";

        [Browsable(false)]
        public string KriterijumPretrage { get; set; }

        [Browsable(false)]
        public string VrednostiZaIzmenu => $"ime='{Ime}', prezime='{Prezime}', datumRodjenja='{DatumRodjenja.ToString("MM/dd/yyyy")}', korisnickoIme= '{Zaposleni.KorisnickoIme}'";

        [Browsable(false)]
        public string UslovObrade => $"idUcenika={IDUcenika}";

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

        public override bool Equals(object obj)
        {
            return obj is Ucenik ucenik &&
                   IDUcenika == ucenik.IDUcenika;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
