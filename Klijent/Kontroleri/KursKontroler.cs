using Domen;
using Klijent.KorisnickeKontrole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class KursKontroler
    {
        private UcKreirajKurs ucKreirajKurs;
        private FormMode mode;
        private Kurs kurs;
        private Zaposleni ulogovaniZaposleni;
        public UcKreirajKurs KreirajUcKreirajKurs(FormMode mode, Kurs kurs, Zaposleni ulogovaniZaposleni)
        {
            this.mode = mode;
            this.kurs= kurs;
            this.ulogovaniZaposleni = ulogovaniZaposleni;

            ucKreirajKurs = new UcKreirajKurs();

            //napuni predavace
            List<Predavac> predavaci = Komunikacija.Instance.VratiSvePredavace();
            ucKreirajKurs.cmbPredavaci.DataSource = predavaci;

            if(mode== FormMode.Dodaj)
            {
                this.kurs = new Kurs();

                ucKreirajKurs.lblKreiranjeKursa.Visible = true;
                ucKreirajKurs.lblIzmeniKurs.Visible = false;

                ucKreirajKurs.btnKreiraj.Visible = true;   
                ucKreirajKurs.btnIzmeni.Visible = false;

            }

            //dogadjaji
            ucKreirajKurs.btnKreiraj.Click += KreirajKurs;

            return ucKreirajKurs;
        }

        public void KreirajKurs(object sender, EventArgs e)
        {
            try
            {
                PreuzmiPodatkeOKursu();

                Komunikacija.Instance.KreirajKurs(kurs);

                ucKreirajKurs.Dispose();

            }
            catch (Exception ex)
            {


            }
        }

        private void PreuzmiPodatkeOKursu()
        {
            //obavezna polja
            if (ucKreirajKurs.txtNazivKursa.Text == "")
            {
                ucKreirajKurs.lblNazivGreska.Text = "Morate uneti naziv kursa";
                ucKreirajKurs.lblNazivGreska.Visible = true;
                throw new KorisnickaGreska("greska >> naziv kursa");
            }
            if (ucKreirajKurs.txtTrajanje.Text == "")
            {
                ucKreirajKurs.lblTrajanjeGreska.Text = "Morate uneti trajanje kursa";
                ucKreirajKurs.lblTrajanjeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> trajanje kursa");
            }
            if (ucKreirajKurs.txtOpis.Text == "")
            {
                ucKreirajKurs.lblOpisGreska.Text = "Morate uneti opis kursa";
                ucKreirajKurs.lblOpisGreska.Visible= true;
                throw new KorisnickaGreska("greska >> opis kursa");
            }
            if (ucKreirajKurs.cmbPredavaci.SelectedIndex < 0)
            {
                ucKreirajKurs.lblPredavacGreska.Text = "Morate odabrati predavača";
                ucKreirajKurs.lblPredavacGreska.Visible = true;
                throw new KorisnickaGreska("greska >> predavac");
            }

            //validna forma
            if (!ucKreirajKurs.txtTrajanje.Text.All(x => char.IsDigit(x)))
            {
                ucKreirajKurs.lblTrajanjeGreska.Text = "Trajanje kursa može da sadrži samo brojeve";
                ucKreirajKurs.lblTrajanjeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> trajanje kursa brojevi");
            }

            //max karaktera
            if (ucKreirajKurs.txtNazivKursa.Text.Length > 40)
            {
                ucKreirajKurs.lblNazivGreska.Text = "Naziv ne sme da ima više od 50 karaktera";
                ucKreirajKurs.lblNazivGreska.Visible = true;
                throw new KorisnickaGreska("greska >> naziv kursa karakteri");
            }
            if (ucKreirajKurs.txtOpis.Text.Length > 300)
            {
                ucKreirajKurs.lblOpisGreska.Text = "Opis ne sme da ima više od 300 karaktera";
                ucKreirajKurs.lblOpisGreska.Visible = true;
                throw new KorisnickaGreska("greska >> opis kursa karakteri");
            }

            kurs.NazivKursa = ucKreirajKurs.txtNazivKursa.Text;
            kurs.OpisKursa = ucKreirajKurs.txtOpis.Text;
            kurs.TrajanjeUMesecima = Int32.Parse(ucKreirajKurs.txtTrajanje.Text);
            kurs.Predavac = (Predavac)ucKreirajKurs.cmbPredavaci.SelectedItem;
            kurs.Zaposleni = ulogovaniZaposleni;
        }
    }
}
