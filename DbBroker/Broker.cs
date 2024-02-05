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
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=kursevi;Integrated Security=True;");
        }

        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();    
        }

        public List<DomenskiObjekat> VratiSve(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {domenskiObjekat.PovratneVrednosti} FROM {domenskiObjekat.NazivTabele} {domenskiObjekat.Join}";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public int Sacuvaj(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"INSERT INTO {domenskiObjekat.NazivTabele} VALUES ({domenskiObjekat.VrednostiZaUnos})";
            return command.ExecuteNonQuery();
        }

        public List<DomenskiObjekat> Pretrazi(DomenskiObjekat domenskiObjekat, string uslovObrade)
        {
            SqlCommand command = new SqlCommand("", connection,transaction);
            command.CommandText= $"select * from {domenskiObjekat.NazivTabele} {domenskiObjekat.Join} where {uslovObrade} ";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public DomenskiObjekat Vrati(DomenskiObjekat domenskiObjekat, string uslovObrade)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {domenskiObjekat.NazivTabele} {domenskiObjekat.Join} where {uslovObrade}";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.VratiListu(reader);
            reader.Close();
            if (rezultat.Count > 0) return rezultat[0];
            return null;
        }
    }
}
