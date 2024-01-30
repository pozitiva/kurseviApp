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
    public class Kurs : DomenskiObjekat
    {
        [Browsable (false)]
        public int IDKursa { get; set; }    
        public string NazivKursa { get; set; }
        public int TrajanjeUMesecima { get; set; }
        public string OpisKursa { get; set; }
        public Predavac Predavac { get; set; }
        public Zaposleni Zaposleni { get; set; }

        [Browsable(false)]
        public string NazivTabele => "Kurs";

        [Browsable(false)]
        public string VrednostiZaUnos => $" '{NazivKursa}','{TrajanjeUMesecima}','{OpisKursa}',' {Predavac.IDPredavaca}', '{Zaposleni.KorisnickoIme}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => " join predavac p on p.idpredavaca= kurs.idpredavaca join zaposleni z on z.korisnickoime = kurs.korisnickoime";

        [Browsable(false)]
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> kursevi = new List<DomenskiObjekat>();
            while(reader.Read())
            {
                Kurs kurs = new Kurs()
                {
                    IDKursa = reader.GetInt32(0),
                    NazivKursa = reader.GetString(1),
                    TrajanjeUMesecima = reader.GetInt32(2),
                    OpisKursa = reader.GetString(3),
                    Zaposleni = new Zaposleni()
                    {
                        KorisnickoIme = reader.GetString(4),
                        Sifra = reader.GetString(7)
                    },
                    Predavac = new Predavac()
                    {
                        IDPredavaca = reader.GetInt32(5),
                        Ime = reader.GetString(9),
                        Prezime = reader.GetString(10),
                        DatumRodjenja = reader.GetDateTime(11)
                    }

                };

                kursevi.Add(kurs);
            }

            return kursevi;
        }
    }
}
