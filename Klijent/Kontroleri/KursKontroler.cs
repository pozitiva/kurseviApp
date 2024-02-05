using Domen;
using Klijent.KorisnickeKontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private UcPrikaziKurseve ucPrikaziKurseve;
        private UcPrikaziKurs ucPrikaziKurs;
        private FormMode mode;
        private Kurs kurs;

        public UcKreirajKurs KreirajUcKreirajKurs(FormMode mode, Kurs kurs)
        {
            this.mode = mode;
            this.kurs= kurs;
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
                ucKreirajKurs.lblNazivGreska.Text = "Naziv ne sme da ima više od 40 karaktera";
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
            kurs.Zaposleni = GlavniKoordinator.Instance.ulogovaniZaposleni;
        }

        public UcPrikaziKurseve KreirajUcPrikaziKurseve()
        {
            ucPrikaziKurseve = new UcPrikaziKurseve();

            ucPrikaziKurseve.dgvKursevi.DataSource = new BindingList<Kurs>(Komunikacija.Instance.VratiSveKurseve());
            ucPrikaziKurseve.dgvKursevi.Columns["opiskursa"].Visible = false;
            ucPrikaziKurseve.dgvKursevi.Columns["trajanjeumesecima"].HeaderText = "Trajanje u mesecima";
            ucPrikaziKurseve.dgvKursevi.Columns["nazivkursa"].HeaderText = "Naziv kursa";
            ucPrikaziKurseve.dgvKursevi.Columns["predavac"].HeaderText = "Predavač";

            //dogadjaji
            ucPrikaziKurseve.btnPrikaziSveKurseve.Click += PrikaziSveKurseve;
            ucPrikaziKurseve.txtFilter.TextChanged += TxtFilterPretrazi;
            ucPrikaziKurseve.btnIzaberi.Click += IzaberiKursZaPrikaz;


            return ucPrikaziKurseve;
        }

        private void IzaberiKursZaPrikaz(object sender, EventArgs e)
        {
            try
            {

                if (ucPrikaziKurseve.dgvKursevi.SelectedRows.Count != 1)
                {
                    ucPrikaziKurseve.lblSelektovanKursGreska.Text = "Morate da odaberete jedan kurs";
                    ucPrikaziKurseve.lblSelektovanKursGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovan kurs");
                }

                Kurs kurs = (Kurs)ucPrikaziKurseve.dgvKursevi.SelectedRows[0].DataBoundItem;
                Kurs k = Komunikacija.Instance.VratiKurs(kurs);
                GlavniKoordinator.Instance.PrikaziPodatkeOKursu(k);
            }
            catch (KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFilterPretrazi(object sender, EventArgs e)
        {
            try
            {
                string filter = ucPrikaziKurseve.txtFilter.Text;
                if (filter.Length > 0)
                {
                    Kurs k = new Kurs()
                    {
                        UslovObrade = $" lower(Kurs.nazivkursa) like '%{filter}%' or lower(p.prezime) like '{filter}%' or lower(p.ime) like '{filter}%'"
                    };
                    List<Kurs> filtriraniKursevi = Komunikacija.Instance.PretraziKurs(k);
                    ucPrikaziKurseve.dgvKursevi.DataSource = filtriraniKursevi;
                }
                else
                {
                    List<Kurs> kursevi = Komunikacija.Instance.VratiSveKurseve();
                    ucPrikaziKurseve.dgvKursevi.DataSource = kursevi;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PrikaziSveKurseve(object sender, EventArgs e)
        {
            try
            {
                ucPrikaziKurseve.dgvKursevi.DataSource = new BindingList<Kurs>(Komunikacija.Instance.VratiSveKurseve());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public UcPrikaziKurs KreirajUcPrikaziKurs(Kurs k)
        {
            ucPrikaziKurs = new UcPrikaziKurs();

            ucPrikaziKurs.txtNazivKursa.Text = k.NazivKursa;
            ucPrikaziKurs.txtTrajanje.Text = k.TrajanjeUMesecima.ToString();
            ucPrikaziKurs.txtOpis.Text = k.OpisKursa;
            ucPrikaziKurs.txtPredavac.Text = k.Predavac.ToString();


            ucPrikaziKurs.btnPrikaziSve.Click += (s, e) => GlavniKoordinator.Instance.PrikaziSveKurseve();

            return ucPrikaziKurs;
        }
    }
}
