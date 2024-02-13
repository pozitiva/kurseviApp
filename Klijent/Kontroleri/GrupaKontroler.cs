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
    public class GrupaKontroler
    {
        UcUpravljajGrupom ucUpravljajGrupom;
        UcPrikaziGrupe ucPrikaziGrupe;
        FormMode mode;
        Grupa grupa;
        public List<PripadanjeGrupi> izbacena = new List<PripadanjeGrupi>();


        public UcUpravljajGrupom KreirajUcUpravljajGrupom(FormMode mode, Grupa grupa)
        {
            this.mode = mode;
            ucUpravljajGrupom = new UcUpravljajGrupom();

            //napuni kurseve
            List<Kurs> kursevi = Komunikacija.Instance.VratiSveKurseve();
            ucUpravljajGrupom.dgvKurs.DataSource = kursevi;

            //napuni ucenike
            ucUpravljajGrupom.dgvUcenici.DataSource = new BindingList<PripadanjeGrupi>();
            ucUpravljajGrupom.cmbUcenici.DataSource = Komunikacija.Instance.VratiSveUcenike();
            ucUpravljajGrupom.cmbUcenici.SelectedIndex = -1;
            ucUpravljajGrupom.dgvUcenici.ReadOnly = true;
            ucUpravljajGrupom.cmbUcenici.DropDownStyle = ComboBoxStyle.DropDownList;

            if (mode == FormMode.Dodaj)
            {
                this.grupa = new Grupa();
                this.grupa.Pripadanja = new BindingList<PripadanjeGrupi>();  
                ucUpravljajGrupom.lblIzmeniGrupu.Visible = false;
                ucUpravljajGrupom.btnIzmeni.Visible = false;
                ucUpravljajGrupom.dgvUcenici.Columns["Grupa"].Visible=false;
            }

            if (mode == FormMode.Izmeni)
            {
                this.grupa = grupa;

                ucUpravljajGrupom.lblKreirajGrupu.Visible = false;
                ucUpravljajGrupom.lblIzmeniGrupu.Visible = true;
                ucUpravljajGrupom.btnKreiraj.Visible = false;
                ucUpravljajGrupom.btnIzmeni.Visible = true;

                ucUpravljajGrupom.txtNazivGrupe.Text = grupa.NazivGrupe;
                ucUpravljajGrupom.dtpDatumPocetka.Text = grupa.DatumPocetkaKursa.ToString();
                ucUpravljajGrupom.dgvUcenici.DataSource = grupa.Pripadanja;
                ucUpravljajGrupom.dgvKurs.DataBindingComplete += SelektujIzabraniKurs;
            }

            //dogadjaji
            ucUpravljajGrupom.btnKreiraj.Click += KreirajGrupu;
            ucUpravljajGrupom.btnIzmeni.Click += IzmeniGrupu;
            ucUpravljajGrupom.btnDodaj.Click += DodajUcenika;
            ucUpravljajGrupom.btnIzbaci.Click += IzbaciUcenika;
            return ucUpravljajGrupom;
        }

        private void IzbaciUcenika(object sender, EventArgs e)
        {
            try
            {
                if (ucUpravljajGrupom.dgvUcenici.SelectedRows.Count != 1)
                {
                    ucUpravljajGrupom.lblUceniciGreska.Text = "Morate da odaberete jednog po jednog ucenika";
                    ucUpravljajGrupom.lblUceniciGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovan ucenik");
                }

                PripadanjeGrupi pripadanje = (PripadanjeGrupi)ucUpravljajGrupom.dgvUcenici.SelectedRows[0].DataBoundItem;
                grupa.Pripadanja.Remove(pripadanje);
                izbacena.Add(pripadanje);
                ucUpravljajGrupom.dgvUcenici.DataSource = grupa.Pripadanja;
            }catch(KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodajUcenika(object sender, EventArgs e)
        {
            if(ucUpravljajGrupom.cmbUcenici.SelectedIndex == -1)
            {
                return;
            }
            PripadanjeGrupi novoPripadanje = new PripadanjeGrupi();
            if (mode == FormMode.Dodaj)
            {
                novoPripadanje.Ucenik = (Ucenik)ucUpravljajGrupom.cmbUcenici.SelectedItem;
                novoPripadanje.DatumPrijave = DateTime.Now;
            }

            if (mode == FormMode.Izmeni)
            {
                novoPripadanje.Ucenik = (Ucenik)ucUpravljajGrupom.cmbUcenici.SelectedItem;
                novoPripadanje.Grupa = grupa;
                novoPripadanje.DatumPrijave = DateTime.Now;
            }

            if (grupa.Pripadanja != null)
            {
                foreach (PripadanjeGrupi pg in grupa.Pripadanja)
                {
                    if (pg.Ucenik.Equals(novoPripadanje.Ucenik))
                    {
                        return;
                    }
                }
            }
            grupa.Pripadanja.Add(novoPripadanje);
            ucUpravljajGrupom.dgvUcenici.DataSource = grupa.Pripadanja;
        }

        private void SelektujIzabraniKurs(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow red in ucUpravljajGrupom.dgvKurs.Rows)
            {
                Kurs kurs = (Kurs)red.DataBoundItem;
                if (kurs.Equals(this.grupa.Kurs))
                {
                    red.Selected = true;
                }
            }
        }

        public UcPrikaziGrupe KreirajUcPrikaziGrupe()
        {
                ucPrikaziGrupe = new UcPrikaziGrupe();
                ucPrikaziGrupe.dgvGrupe.DataSource = new BindingList<Grupa>(Komunikacija.Instance.VratiSveGrupe());
                ucPrikaziGrupe.dgvGrupe.Columns["nazivgrupe"].HeaderText = "Naziv grupe";
                ucPrikaziGrupe.dgvGrupe.Columns["datumpocetkakursa"].HeaderText = "Datum početka kursa";

                //dogadjaji
                ucPrikaziGrupe.txtFilter.TextChanged += TxtFilterPretrazi;
                ucPrikaziGrupe.btnIzaberi.Click += IzaberiGrupuZaIzmenu;
                ucPrikaziGrupe.btnPrikaziSve.Click += PrikaziSveGrupe;

                return ucPrikaziGrupe;
        }

        private void PrikaziSveGrupe(object sender, EventArgs e)
        {
            try
            {
                ucPrikaziGrupe.dgvGrupe.DataSource = Komunikacija.Instance.VratiSveGrupe();
            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void IzaberiGrupuZaIzmenu(object sender, EventArgs e)
        {
            try
            {

                if (ucPrikaziGrupe.dgvGrupe.SelectedRows.Count != 1)
                {
                    ucPrikaziGrupe.lblSelektovanaGrupaGreska.Text = "Morate da odaberete jednu grupu";
                    ucPrikaziGrupe.lblSelektovanaGrupaGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovana grupa");
                }

                Grupa grupa = (Grupa)ucPrikaziGrupe.dgvGrupe.SelectedRows[0].DataBoundItem;
                Grupa g = Komunikacija.Instance.VratiGrupu(grupa);
                GlavniKoordinator.Instance.PrikaziGrupuZaIzmenu(g);
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
                string filter = ucPrikaziGrupe.txtFilter.Text;
                if (filter.Length > 0)
                {
                    Grupa grupa = new Grupa
                    {
                        KriterijumPretrage = $" lower(Grupa.nazivgrupe) like '%{filter}%' or lower(Grupa.korisnickoime) like '{filter}%' or lower(Grupa.idkursa) like '{filter}%'"
                    };
                    List<Grupa> filtriraneGrupe = Komunikacija.Instance.PretraziGrupe(grupa);
                    ucPrikaziGrupe.dgvGrupe.DataSource = filtriraneGrupe;
                }
                else
                {
                    List<Grupa> grupe = Komunikacija.Instance.VratiSveGrupe();
                    ucPrikaziGrupe.dgvGrupe.DataSource = grupe;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void IzmeniGrupu(object sender, EventArgs e)
        {
            try
            {
                ucUpravljajGrupom.lblNazivGreska.Visible = false;
                ucUpravljajGrupom.lblKursGreska.Visible = false;
                ucUpravljajGrupom.lblUceniciGreska.Visible = false;
                ucUpravljajGrupom.lblDatumGreska.Visible = false;

                PreuzmiPodatkeOGrupi();

                Komunikacija.Instance.IzmeniGrupu(grupa);
                GlavniKoordinator.Instance.PrikaziSveGrupe();

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

        private void KreirajGrupu(object sender, EventArgs e)
        {
            try
            {
                PreuzmiPodatkeOGrupi();

                Komunikacija.Instance.KreirajGrupu(grupa);

                ucUpravljajGrupom.Dispose();

            }
            catch(KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PreuzmiPodatkeOGrupi()
        {
            //obavezna polja
            if (ucUpravljajGrupom.txtNazivGrupe.Text == "")
            {
                ucUpravljajGrupom.lblNazivGreska.Text = "Morate uneti naziv grupe";
                ucUpravljajGrupom.lblNazivGreska.Visible = true;
                throw new KorisnickaGreska("greska >> naziv grupe");
            }
            if (ucUpravljajGrupom.dtpDatumPocetka.Text == "")
            {
                ucUpravljajGrupom.lblDatumGreska.Text = "Morate uneti datum pocetka kursa";
                ucUpravljajGrupom.lblDatumGreska.Visible = true;
                throw new KorisnickaGreska("greska >> datum pocetka kursa");
            }
            //max karaktera
            if (ucUpravljajGrupom.txtNazivGrupe.TextLength > 40)
            {
                ucUpravljajGrupom.lblNazivGreska.Text = "Naziv grupe ne sme da ima više od 40 karaktera";
                ucUpravljajGrupom.lblNazivGreska.Visible = true;
                throw new KorisnickaGreska("greska >> naziv grupe karakteri");
            }

            if (ucUpravljajGrupom.dgvKurs.SelectedRows.Count != 1)
            {
                ucUpravljajGrupom.lblKursGreska.Visible = true;
                throw new KorisnickaGreska("greska >> selektovan kurs");
            }

            grupa.NazivGrupe = ucUpravljajGrupom.txtNazivGrupe.Text;
            grupa.DatumPocetkaKursa = ucUpravljajGrupom.dtpDatumPocetka.Value;
            grupa.Kurs = (Kurs)ucUpravljajGrupom.dgvKurs.SelectedRows[0].DataBoundItem;
            grupa.Zaposleni = GlavniKoordinator.Instance.ulogovaniZaposleni;
            grupa.IzbacenaPripadanja = izbacena;

        }
    }
}
