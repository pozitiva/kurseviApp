using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        public List<DomenskiObjekat> Vrati(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {domenskiObjekat.PovratneVrednosti} FROM {domenskiObjekat.NazivTabele} {domenskiObjekat.Join}";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }
    }
}
