using Domen;
using Klijent.KorisnickeKontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class UcenikKontroler
    {
        private UcUpravljajUcenikom ucUpravljajUcenikom;
        private UcPrikaziUcenike ucPrikaziUcenike;
        private FormMode mode;
        private Ucenik ucenik;

        public UcUpravljajUcenikom KreirajUcUpravljajUcenikom(FormMode mode, Ucenik ucenik)
        {
            this.mode = mode;
            this.ucenik = ucenik;
            ucUpravljajUcenikom = new UcUpravljajUcenikom();

            if (mode == FormMode.Dodaj)
            {
                this.ucenik = new Ucenik();

                ucUpravljajUcenikom.lblIzmeniUcenika.Visible = false;
                ucUpravljajUcenikom.lblObrisiUcenika.Visible = false;

                ucUpravljajUcenikom.btnIzmeni.Visible = false;
                ucUpravljajUcenikom.btnPrikaziSve.Visible = false;
                ucUpravljajUcenikom.btnObrisi.Visible = false;

                ucUpravljajUcenikom.txtDatum.Visible = false;   
            }

            if (mode == FormMode.Izmeni)
            {
                ucUpravljajUcenikom.lblKreiranjeUcenika.Visible = false;
                ucUpravljajUcenikom.lblObrisiUcenika.Visible = false;
              

                ucUpravljajUcenikom.btnKreiraj.Visible = false;
                ucUpravljajUcenikom.btnPrikaziSve.Visible = false;
                ucUpravljajUcenikom.btnObrisi.Visible = false;

                ucUpravljajUcenikom.txtIme.Text = ucenik.Ime;
                ucUpravljajUcenikom.txtPrezime.Text = ucenik.Prezime;
                ucUpravljajUcenikom.dtpDatum.Text = ucenik.DatumRodjenja.ToString();

                ucUpravljajUcenikom.txtDatum.Visible = false;

            }

            if (mode == FormMode.Obrisi)
            {
                ucUpravljajUcenikom.lblIzmeniUcenika.Visible = false;
                ucUpravljajUcenikom.lblKreiranjeUcenika.Visible = false;

                ucUpravljajUcenikom.btnKreiraj.Visible = false;
                ucUpravljajUcenikom.btnPrikaziSve.Visible = false;
                ucUpravljajUcenikom.btnIzmeni.Visible = false;

                ucUpravljajUcenikom.txtIme.Text = ucenik.Ime;
                ucUpravljajUcenikom.txtPrezime.Text = ucenik.Prezime;
                ucUpravljajUcenikom.txtDatum.Text = ucenik.DatumRodjenja.ToString();

                ucUpravljajUcenikom.txtIme.ReadOnly = true;
                ucUpravljajUcenikom.txtPrezime.ReadOnly = true;
                ucUpravljajUcenikom.dtpDatum.Visible = false;
                ucUpravljajUcenikom.txtDatum.ReadOnly = true;
            }


            //dogadjaji
            ucUpravljajUcenikom.btnKreiraj.Click += KreirajUcenika;
            ucUpravljajUcenikom.btnIzmeni.Click += IzmeniUcenika;
            ucUpravljajUcenikom.btnObrisi.Click += ObrisiKurs;
            ucUpravljajUcenikom.btnPrikaziSve.Click += (s, e) => GlavniKoordinator.Instance.PrikaziSveUcenike();

            return ucUpravljajUcenikom;

        }

        private void ObrisiKurs(object sender, EventArgs e)
        {
            try
            {
                ucUpravljajUcenikom.lblImeGreska.Visible = false;
                ucUpravljajUcenikom.lblPrezimeGreska.Visible = false;
                ucUpravljajUcenikom.lblDatumGreska.Visible = false;

                PreuzmiPodatkeOUceniku();

                Komunikacija.Instance.ObrisiUcenika(ucenik);
                GlavniKoordinator.Instance.PrikaziSveUcenike();

            }
            catch (KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzmeniUcenika(object sender, EventArgs e)
        {
            try
            {
                ucUpravljajUcenikom.lblImeGreska.Visible = false;
                ucUpravljajUcenikom.lblPrezimeGreska.Visible = false;
                ucUpravljajUcenikom.lblDatumGreska.Visible = false;

                PreuzmiPodatkeOUceniku();

                Komunikacija.Instance.IzmeniUcenika(ucenik);
                GlavniKoordinator.Instance.PrikaziSveUcenike();

            }
            catch (KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KreirajUcenika(object sender, EventArgs e)
        {
            try
            {
                PreuzmiPodatkeOUceniku();

                Komunikacija.Instance.KreirajUcenika(ucenik);

                ucUpravljajUcenikom.Dispose();

            }catch(KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PreuzmiPodatkeOUceniku()
        {
            //obavezna polja
            if (ucUpravljajUcenikom.txtIme.Text == "")
            {
                ucUpravljajUcenikom.lblImeGreska.Text = "Morate uneti ime ucenika";
                ucUpravljajUcenikom.lblImeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> ime ucenika");
            }
            if (ucUpravljajUcenikom.txtPrezime.Text == "" )
            {
                ucUpravljajUcenikom.lblPrezimeGreska.Text = "Morate uneti prezime ucenika";
                ucUpravljajUcenikom.lblPrezimeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> prezime ucenika");
            }
            if (ucUpravljajUcenikom.dtpDatum.Text == "" && ucUpravljajUcenikom.txtDatum.Text == "")
            {
                ucUpravljajUcenikom.lblDatumGreska.Text = "Morate uneti datum rodjenja";
                ucUpravljajUcenikom.lblDatumGreska.Visible = true;
                throw new KorisnickaGreska("greska >> datum rodjenja");
            }

            //max karaktera
            if (ucUpravljajUcenikom.txtIme.TextLength > 40)
            {
                ucUpravljajUcenikom.lblImeGreska.Text = "Ime ucenika ne sme da ima više od 40 karaktera";
                ucUpravljajUcenikom.lblImeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> ime ucenika karakteri");
            }
            if (ucUpravljajUcenikom.txtPrezime.Text.Length > 40)
            {
                ucUpravljajUcenikom.lblPrezimeGreska.Text = "Prezime ucenika ne sme da ima više od 40 karaktera";
                ucUpravljajUcenikom.lblPrezimeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> prezime ucenika karakteri");
            }

            ucenik.Ime = ucUpravljajUcenikom.txtIme.Text;
            ucenik.Prezime = ucUpravljajUcenikom.txtPrezime.Text;
            ucenik.DatumRodjenja = ucUpravljajUcenikom.dtpDatum.Value;
            ucenik.Zaposleni = GlavniKoordinator.Instance.ulogovaniZaposleni;

        }

        public UcPrikaziUcenike KreirajUcPrikaziUcenike(FormMode mode)
        {
            ucPrikaziUcenike = new UcPrikaziUcenike();

            ucPrikaziUcenike.dgvUcenici.DataSource = new BindingList<Ucenik>(Komunikacija.Instance.VratiSveUcenike());
            ucPrikaziUcenike.dgvUcenici.Columns["datumrodjenja"].HeaderText = "Datum Rodjenja";
            ucPrikaziUcenike.dgvUcenici.Columns["ime"].HeaderText = "Ime";
            ucPrikaziUcenike.dgvUcenici.Columns["prezime"].HeaderText = "Prezime";

            if (mode == FormMode.Izmeni)
            {
                ucPrikaziUcenike.btnObrisi.Visible = false;
            }
            if (mode == FormMode.Prikazi)
            {
                ucPrikaziUcenike.btnIzmeni.Visible = false;
                ucPrikaziUcenike.btnObrisi.Visible = false;
            }
            if (mode == FormMode.Obrisi)
            {
                ucPrikaziUcenike.btnIzmeni.Visible = false;
            }

            //dogadjaji
            ucPrikaziUcenike.txtFilter.TextChanged += TxtFilterPretrazi;
            ucPrikaziUcenike.btnIzmeni.Click += IzaberiUcenikaZaIzmenu;
            ucPrikaziUcenike.btnObrisi.Click += IzaberiUcenikaZaBrisanje;
            ucPrikaziUcenike.btnPrikaziSveUcenike.Click += PrikaziSveUcenike;

            return ucPrikaziUcenike;
        }

        private void PrikaziSveUcenike(object sender, EventArgs e)
        {
            try
            {
                ucPrikaziUcenike.dgvUcenici.DataSource = new BindingList<Ucenik>(Komunikacija.Instance.VratiSveUcenike());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzaberiUcenikaZaBrisanje(object sender, EventArgs e)
        {
            try
            {
                if (ucPrikaziUcenike.dgvUcenici.SelectedRows.Count != 1)
                {
                    ucPrikaziUcenike.lblSelektovanUcenikGreska.Text = "Morate da odaberete jednog ucenika";
                    ucPrikaziUcenike.lblSelektovanUcenikGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovan ucenik");
                }
                Ucenik ucenik = (Ucenik)ucPrikaziUcenike.dgvUcenici.SelectedRows[0].DataBoundItem;
                Ucenik u = Komunikacija.Instance.VratiUcenika(ucenik);
                GlavniKoordinator.Instance.PrikaziUcenikaZaBrisanje(u);

            }
            catch (KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzaberiUcenikaZaIzmenu(object sender, EventArgs e)
        {
            try
            {

                if (ucPrikaziUcenike.dgvUcenici.SelectedRows.Count != 1)
                {
                    ucPrikaziUcenike.lblSelektovanUcenikGreska.Text = "Morate da odaberete jednog ucenika";
                    ucPrikaziUcenike.lblSelektovanUcenikGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovan ucenik");
                }

                Ucenik ucenik = (Ucenik)ucPrikaziUcenike.dgvUcenici.SelectedRows[0].DataBoundItem;
                Ucenik u = Komunikacija.Instance.VratiUcenika(ucenik);
                GlavniKoordinator.Instance.PrikaziUcenikaZaIzmenu(u);
            }
            catch (KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
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
                string filter = ucPrikaziUcenike.txtFilter.Text;
                if (filter.Length > 0)
                {
                    Ucenik u = new Ucenik
                    {
                        KriterijumPretrage = $" lower(Ucenik.ime) like '%{filter}%' or lower(Ucenik.prezime) like '{filter}%'"
                    };
                    List<Ucenik> filtriraniUcenici = Komunikacija.Instance.PretraziUcenike(u);
                    ucPrikaziUcenike.dgvUcenici.DataSource = filtriraniUcenici;
                }
                else
                {
                    List<Ucenik> ucenici = Komunikacija.Instance.VratiSveUcenike();
                    ucPrikaziUcenike.dgvUcenici.DataSource = ucenici;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
