using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public class GenerickiDbRepozitorijum:IDbRepozitorijum<DomenskiObjekat>
    {

        public List<DomenskiObjekat> VratiSve(DomenskiObjekat domenskiObjekat)
        {
            string komanda =  $"SELECT {domenskiObjekat.PovratneVrednosti} FROM {domenskiObjekat.NazivTabele} {domenskiObjekat.Join}";
            SqlCommand cmd = DbKonekcioniFaktor.Instance.VratiDbKonekciju().KreirajKomandu(komanda);
            SqlDataReader reader = cmd.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public int Sacuvaj(DomenskiObjekat domenskiObjekat)
        {
            string komanda = $"INSERT INTO {domenskiObjekat.NazivTabele} VALUES ({domenskiObjekat.VrednostiZaUnos})";
            SqlCommand cmd = DbKonekcioniFaktor.Instance.VratiDbKonekciju().KreirajKomandu(komanda);
            return cmd.ExecuteNonQuery();
        }

        public List<DomenskiObjekat> Pretrazi(DomenskiObjekat domenskiObjekat)
        {
            string komanda = $"select * from {domenskiObjekat.NazivTabele} {domenskiObjekat.Join} where {domenskiObjekat.KriterijumPretrage} ";
            SqlCommand cmd = DbKonekcioniFaktor.Instance.VratiDbKonekciju().KreirajKomandu(komanda);
            SqlDataReader reader = cmd.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public DomenskiObjekat Vrati(DomenskiObjekat domenskiObjekat)
        {
            string komanda = $"select * from {domenskiObjekat.NazivTabele} {domenskiObjekat.Join} where {domenskiObjekat.UslovObrade}";
            SqlCommand cmd = DbKonekcioniFaktor.Instance.VratiDbKonekciju().KreirajKomandu(komanda);
            SqlDataReader reader = cmd.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.VratiListu(reader);
            reader.Close();
            if (rezultat.Count > 0) return rezultat[0];
            return null;
        }

        public int Izmeni(DomenskiObjekat domenskiObjekat)
        {
            string komanda = $"UPDATE {domenskiObjekat.NazivTabele} SET {domenskiObjekat.VrednostiZaIzmenu} WHERE {domenskiObjekat.UslovObrade}";
            SqlCommand cmd = DbKonekcioniFaktor.Instance.VratiDbKonekciju().KreirajKomandu(komanda);
            return cmd.ExecuteNonQuery();
        }

        public int Obrisi(DomenskiObjekat domenskiObjekat)
        {
            string komanda = $"DELETE FROM {domenskiObjekat.NazivTabele} WHERE {domenskiObjekat.UslovObrade}";
            SqlCommand cmd = DbKonekcioniFaktor.Instance.VratiDbKonekciju().KreirajKomandu(komanda);
            return cmd.ExecuteNonQuery();
        }

        public void Commit()
        {
            DbKonekcioniFaktor.Instance.VratiDbKonekciju().Commit();
        }

        public void Rollback()
        {
            DbKonekcioniFaktor.Instance.VratiDbKonekciju().Rollback();
        }

        public void ZatvoriKonekciju()
        {
            DbKonekcioniFaktor.Instance.VratiDbKonekciju().ZatvoriKonekciju();
        }
    }
}
