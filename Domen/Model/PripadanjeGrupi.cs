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
    public class PripadanjeGrupi : DomenskiObjekat
    {
        public Grupa Grupa { get; set; }
        public Ucenik Ucenik { get; set; }
        public DateTime DatumPrijave { get; set; }
        public string Napomena { get; set; }

        [Browsable(false)]
        public string NazivTabele => "PripadanjeGrupi";

        [Browsable(false)]
        public string VrednostiZaUnos => $"'{Grupa.IDGrupe}', '{Ucenik.IDUcenika}', '{DatumPrijave}', '{Napomena}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => "join grupa g on pripadanjegrupi.idGrupe= g.idGrupe join zaposleni z on g.korisnickoIme= z.korisnickoIme join kurs k on g.idKursa= k.idKursa join predavac p on k.idPredavaca=p.idPredavaca join zaposleni z1 on z1.korisnickoIme= k.korisnickoIme join ucenik u on u.idUcenika=pripadanjegrupi.idUcenika join zaposleni z2 on u.korisnickoIme= z2.korisnickoIme";

        [Browsable(false)]
        public string UslovObrade { get; set; }

        [Browsable(false)]
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> pripadanjaGrupi = new List<DomenskiObjekat>();

            while (reader.Read())
            {
                PripadanjeGrupi pripadanjeGrupi = new PripadanjeGrupi()
                {
                    Grupa = new Grupa()
                    {
                        IDGrupe = reader.GetInt32(0),
                        NazivGrupe = reader.GetString(5),
                        DatumPocetkaKursa = reader.GetDateTime(6),
                        Zaposleni = new Zaposleni
                        {
                            KorisnickoIme = reader.GetString(7),
                            Sifra = reader.GetString(10)
                        },
                        Kurs = new Kurs
                        {
                            IDKursa = reader.GetInt32(8),
                            NazivKursa = reader.GetString(12),
                            TrajanjeUMesecima = reader.GetInt32(13),
                            OpisKursa = reader.GetString(14),
                            Zaposleni = new Zaposleni
                            {
                                KorisnickoIme = reader.GetString(15),
                                Sifra = reader.GetString(22),
                            },
                            Predavac = new Predavac
                            {
                                IDPredavaca = reader.GetInt32(16),
                                Ime = reader.GetString(18),
                                Prezime = reader.GetString(19),
                                DatumRodjenja = reader.GetDateTime(20)
                            }
                        }

                    },
                    Ucenik = new Ucenik()
                    {
                        IDUcenika= reader.GetInt32(1),
                        Ime = reader.GetString(24),
                        Prezime = reader.GetString(25),
                        DatumRodjenja= reader.GetDateTime(26),
                        Zaposleni = new Zaposleni
                        {
                            KorisnickoIme= reader.GetString(27),
                            Sifra = reader.GetString(29)
                        }
                    },
                    DatumPrijave = reader.GetDateTime(2),
                    Napomena = reader.GetString(3),
                };

                pripadanjaGrupi.Add(pripadanjeGrupi);

            }

            return pripadanjaGrupi;
        }
    }
}
