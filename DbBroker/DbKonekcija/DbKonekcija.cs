using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public class DbKonekcija
    {
        private SqlConnection konekcija;
        private SqlTransaction transakcija;

        public SqlCommand KreirajKomandu(string sql = "")
        {
            if (transakcija?.Connection == null) transakcija = konekcija.BeginTransaction();

            return new SqlCommand(sql, konekcija, transakcija);
        }
        public void OtvoriKonekciju()
        {
            if(konekcija == null || konekcija.State == ConnectionState.Closed)
            {
                //"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=kursevi;Integrated Security=True;"
                konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
                konekcija.Open();
            }
        }

        public void ZatvoriKonekciju()
        {
            konekcija?.Close();
            transakcija?.Dispose();
        }

        public void PokreniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
        }

        public void Commit()
        {
            transakcija?.Commit();
        }

        public void Rollback()
        {
            transakcija?.Rollback();
        }

        public bool Spremna()
        {
            return (konekcija != null && konekcija.State != ConnectionState.Closed);
        }
    }
}
