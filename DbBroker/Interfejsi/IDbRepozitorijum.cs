using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public interface IDbRepozitorijum<TDomenskiObjekat> : IRepozitorijum<TDomenskiObjekat> where TDomenskiObjekat : class
    {
        void Commit();
        void Rollback();
        void ZatvoriKonekciju();
    }
}
