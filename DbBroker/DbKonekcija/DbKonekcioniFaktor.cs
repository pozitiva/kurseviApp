using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitorijum
{
    public class DbKonekcioniFaktor
    {
        //omogucava da se vise operacija radi pomocu jedne konekcije
        //ne mora da se otvara vise konekcija, vec se koristi ona koja je vec otvorena
        //singleton

        private static DbKonekcioniFaktor instance;
        private DbKonekcija konekcija = new DbKonekcija();
        public static DbKonekcioniFaktor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbKonekcioniFaktor();
                }
                return instance;
            }
        }

        //ako je konekcija vec otvorena, iskoristice nju
        //ako nije, otvorice konekciju
        public DbKonekcija VratiDbKonekciju()
        {
            if (!konekcija.Spremna())
            {
                konekcija.OtvoriKonekciju();
            }
            return konekcija;
        }
    }
}
