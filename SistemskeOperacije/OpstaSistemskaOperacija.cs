using DbBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected abstract object Izvrsavanje(DomenskiObjekat domenskiObjekat);
        protected Broker broker = new Broker();
        public object IzvrsiSO(DomenskiObjekat domenskiObjekat)
        {
            object rezultat = null;
            try
            {
                broker.OtvoriKonekciju();
                broker.PokreniTransakciju();
                rezultat = Izvrsavanje(domenskiObjekat);
                broker.Commit();
            }
            catch (Exception e)
            {
                broker.Rollback();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
            return rezultat;
        }
    }
}
