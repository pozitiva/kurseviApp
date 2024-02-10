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

        [Browsable(false)]
        public string NazivTabele => "PripadanjeGrupi";

        [Browsable(false)]
        public string VrednostiZaUnos => $"'{Grupa.IDGrupe}', '{Ucenik.IDUcenika}', '{DatumPrijave.ToString("yyyy-MM-dd HH:mm:ss")}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => "join grupa g on pripadanjegrupi.idGrupe= g.idGrupe join zaposleni z on g.korisnickoIme= z.korisnickoIme join kurs k on g.idKursa= k.idKursa join predavac p on k.idPredavaca=p.idPredavaca join zaposleni z1 on z1.korisnickoIme= k.korisnickoIme join ucenik u on u.idUcenika=pripadanjegrupi.idUcenika join zaposleni z2 on u.korisnickoIme= z2.korisnickoIme";

        [Browsable(false)]
        public string KriterijumPretrage { get; set; }

        [Browsable(false)]
        public string VrednostiZaIzmenu => $" idgrupe='{Grupa.IDGrupe}', iducenika = '{Ucenik.IDUcenika}', datumprijave = '{DatumPrijave.ToString("yyyy-MM-dd HH:mm:ss")}'";

        [Browsable(false)]
        public string UslovObrade => $"idGrupe = '{Grupa.IDGrupe}'";

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
                        NazivGrupe = reader.GetString(4),
                        DatumPocetkaKursa = reader.GetDateTime(5),
                        Zaposleni = new Zaposleni
                        {
                            KorisnickoIme = reader.GetString(6),
                            Sifra = reader.GetString(9)
                        },
                        Kurs = new Kurs
                        {
                            IDKursa = reader.GetInt32(7),
                            NazivKursa = reader.GetString(11),
                            TrajanjeUMesecima = reader.GetInt32(12),
                            OpisKursa = reader.GetString(13),
                            Zaposleni = new Zaposleni
                            {
                                KorisnickoIme = reader.GetString(14),
                                Sifra = reader.GetString(21),
                            },
                            Predavac = new Predavac
                            {
                                IDPredavaca = reader.GetInt32(15),
                                Ime = reader.GetString(17),
                                Prezime = reader.GetString(18),
                                DatumRodjenja = reader.GetDateTime(19)
                            }
                        }

                    },
                    Ucenik = new Ucenik()
                    {
                        IDUcenika= reader.GetInt32(1),
                        Ime = reader.GetString(23),
                        Prezime = reader.GetString(24),
                        DatumRodjenja= reader.GetDateTime(25),
                        Zaposleni = new Zaposleni
                        {
                            KorisnickoIme= reader.GetString(26),
                            Sifra = reader.GetString(28)
                        }
                    },
                    DatumPrijave = reader.GetDateTime(2),
                    //Napomena = reader.GetString(3),
                };

                pripadanjaGrupi.Add(pripadanjeGrupi);

            }

            return pripadanjaGrupi;
        }

        public override string ToString()
        {
            return Ucenik.Ime + Ucenik.Prezime;
        }
    }
}
