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
    public class Grupa : DomenskiObjekat
    {
        [Browsable(false)]
        public int IDGrupe { get; set; }
        public string NazivGrupe { get; set; }
        public DateTime DatumPocetkaKursa { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public Kurs Kurs { get; set; }

        [Browsable(false)]
        public string NazivTabele => "Grupa";

        [Browsable(false)]
        public string VrednostiZaUnos => $"'{IDGrupe}', '{NazivGrupe}', '{DatumPocetkaKursa}', '{Zaposleni.KorisnickoIme}', '{Kurs.IDKursa}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => "join zaposleni z on z.korisnickoime=grupa.korisnickoime join kurs k on k.idkursa=grupa.idkursa join zaposleni z1 on z1.korisnickoIme = k.korisnickoIme join predavac p on p.idPredavaca= k.idPredavaca";

        [Browsable(false)]
        public string UslovObrade { get; set; }

        [Browsable(false)]
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> grupe = new List<DomenskiObjekat>();

            while (reader.Read())
            {
                Grupa grupa = new Grupa()
                {
                    IDGrupe = reader.GetInt32(0),
                    NazivGrupe = reader.GetString(1),
                    DatumPocetkaKursa = reader.GetDateTime(2),
                    Zaposleni = new Zaposleni()
                    {
                        KorisnickoIme = reader.GetString(3),
                        Sifra = reader.GetString(6)
                    },
                    Kurs = new Kurs()
                    {
                        IDKursa = reader.GetInt32(4),
                        NazivKursa = reader.GetString(8),
                        TrajanjeUMesecima = reader.GetInt32(9),
                        OpisKursa = reader.GetString(10),
                        Zaposleni = new Zaposleni
                        {
                            KorisnickoIme = reader.GetString(11),
                            Sifra = reader.GetString(14),

                        },
                        Predavac = new Predavac
                        {
                            IDPredavaca = reader.GetInt32(12),
                            Ime = reader.GetString(16),
                            Prezime = reader.GetString(17),
                            DatumRodjenja = reader.GetDateTime(18)
                        }
                    }
                };

                grupe.Add(grupa);
            }


            return grupe;
        }
    }

}




