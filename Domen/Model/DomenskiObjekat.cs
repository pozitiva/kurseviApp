using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface DomenskiObjekat
    {
        string NazivTabele {  get; }
        string VrednostiZaUnos {  get; }
        string PovratneVrednosti { get; }
        string Join {  get; }
        string UslovObrade {  get; }
        //string KriterijumPretrage { get; }
        //string VrednostiZaIzmenu { get; }
        List<DomenskiObjekat> VratiListu(SqlDataReader reader);
    }
}
