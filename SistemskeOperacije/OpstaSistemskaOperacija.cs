﻿using Domen;
using Repozitorijum;
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
        protected GenerickiDbRepozitorijum broker = new GenerickiDbRepozitorijum();
        protected DbKonekcija konekcija = new DbKonekcija();
        public object IzvrsiSO(DomenskiObjekat domenskiObjekat)
        {
            object rezultat = null;
            try
            {
                konekcija.OtvoriKonekciju();
                konekcija.PokreniTransakciju();
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
