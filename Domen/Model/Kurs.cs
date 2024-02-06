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
        public string VrednostiZaUnos => $" '{NazivKursa}','{TrajanjeUMesecima}','{OpisKursa}', '{Zaposleni.KorisnickoIme}', ' {Predavac.IDPredavaca}'";

        [Browsable(false)]
        public string PovratneVrednosti => "*";

        [Browsable(false)]
        public string Join => " join predavac p on p.idpredavaca= kurs.idpredavaca join zaposleni z on z.korisnickoime = kurs.korisnickoime";

        [Browsable(false)]
        public string KriterijumPretrage { get; set; }

        [Browsable(false)]
        public string VrednostiZaIzmenu => $"nazivkursa='{NazivKursa}', trajanjeumesecima='{TrajanjeUMesecima}', opiskursa='{OpisKursa}',  idpredavaca='{Predavac.IDPredavaca}', korisnickoIme= '{Zaposleni.KorisnickoIme}'";

        [Browsable(false)]
        public string UslovObrade => $"idkursa='{IDKursa}'";

        [Browsable(false)]
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> kursevi = new List<DomenskiObjekat>();
            while(reader.Read())
            {
                Predavac predavac= new Predavac()
                {
                    IDPredavaca = reader.GetInt32(5),
                    Ime = reader.GetString(7),
                    Prezime = reader.GetString(8),
                    DatumRodjenja = (DateTime)reader["datumrodjenja"]
                };
                Zaposleni zaposleni = new Zaposleni()
                {
                    KorisnickoIme = reader.GetString(10),
                    Sifra = reader.GetString(11)
                };

                Kurs kurs = new Kurs()
                {
                    IDKursa = reader.GetInt32(0),
                    NazivKursa = reader.GetString(1),
                    TrajanjeUMesecima = reader.GetInt32(2),
                    OpisKursa = reader.GetString(3),
                    Zaposleni = zaposleni,
                    Predavac = predavac

                };

                kursevi.Add(kurs);
            }

            return kursevi;
        }
    }
}
