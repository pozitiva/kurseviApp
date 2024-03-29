﻿using Domen;
using Klijent.KorisnickeKontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class KursKontroler
    {
        private UcUpravljajKursom ucUpravljajKursem;
        private UcPrikaziKurseve ucPrikaziKurseve;
        private FormMode mode;
        private Kurs kurs;

        public UcUpravljajKursom KreirajUcUpravljajKurs(FormMode mode, Kurs kurs)
        {
            this.mode = mode;
            this.kurs = kurs;
            ucUpravljajKursem = new UcUpravljajKursom();

            //napuni predavace
            List<Predavac> predavaci = Komunikacija.Instance.VratiSvePredavace();
            ucUpravljajKursem.cmbPredavaci.DataSource = predavaci;

            if (mode == FormMode.Dodaj)
            {
                this.kurs = new Kurs();

                ucUpravljajKursem.lblIzmeniKurs.Visible = false;
                ucUpravljajKursem.lblKurs.Visible = false;
                ucUpravljajKursem.lblObrisiKurs.Visible = false;

                ucUpravljajKursem.btnIzmeni.Visible = false;
                ucUpravljajKursem.btnPrikaziSve.Visible = false;
                ucUpravljajKursem.btnObrisiKurs.Visible = false;

                ucUpravljajKursem.txtPredavac.Visible = false;

            }

            if (mode == FormMode.Izmeni)
            {
                ucUpravljajKursem.lblKreiranjeKursa.Visible = false;
                ucUpravljajKursem.lblKurs.Visible = false;
                ucUpravljajKursem.lblObrisiKurs.Visible = false;

                ucUpravljajKursem.btnKreiraj.Visible = false;
                ucUpravljajKursem.btnPrikaziSve.Visible = false;
                ucUpravljajKursem.btnObrisiKurs.Visible = false;

                ucUpravljajKursem.txtNazivKursa.Text = kurs.NazivKursa;
                ucUpravljajKursem.txtTrajanje.Text = kurs.TrajanjeUMesecima.ToString();
                ucUpravljajKursem.txtOpis.Text = kurs.OpisKursa;
                ucUpravljajKursem.cmbPredavaci.SelectedItem = kurs.Predavac;

                ucUpravljajKursem.txtPredavac.Visible = false;
            }

            if (mode == FormMode.Prikazi)
            {
                ucUpravljajKursem.lblKreiranjeKursa.Visible = false;
                ucUpravljajKursem.lblIzmeniKurs.Visible = false;
                ucUpravljajKursem.lblObrisiKurs.Visible = false;

                ucUpravljajKursem.btnKreiraj.Visible = false;
                ucUpravljajKursem.btnIzmeni.Visible = false;
                ucUpravljajKursem.btnObrisiKurs.Visible = false;

                ucUpravljajKursem.cmbPredavaci.Visible = false;

                ucUpravljajKursem.txtNazivKursa.Text = kurs.NazivKursa;
                ucUpravljajKursem.txtTrajanje.Text = kurs.TrajanjeUMesecima.ToString();
                ucUpravljajKursem.txtOpis.Text = kurs.OpisKursa;
                ucUpravljajKursem.txtPredavac.Text = kurs.Predavac.ToString();

                ucUpravljajKursem.txtNazivKursa.ReadOnly = true;
                ucUpravljajKursem.txtTrajanje.ReadOnly = true;
                ucUpravljajKursem.txtOpis.ReadOnly = true;
                ucUpravljajKursem.txtPredavac.ReadOnly = true;
            }


            if(mode== FormMode.Obrisi)
            {
                ucUpravljajKursem.lblKreiranjeKursa.Visible = false;
                ucUpravljajKursem.lblIzmeniKurs.Visible = false;
                ucUpravljajKursem.lblKurs.Visible = false;

                ucUpravljajKursem.btnKreiraj.Visible = false;
                ucUpravljajKursem.btnIzmeni.Visible = false;
                ucUpravljajKursem.btnPrikaziSve.Visible = false;
                ucUpravljajKursem.cmbPredavaci.Visible = false;
                ucUpravljajKursem.txtPredavac.Visible = true;

                ucUpravljajKursem.txtNazivKursa.Text = kurs.NazivKursa;
                ucUpravljajKursem.txtTrajanje.Text = kurs.TrajanjeUMesecima.ToString();
                ucUpravljajKursem.txtOpis.Text = kurs.OpisKursa;
                ucUpravljajKursem.txtPredavac.Text = kurs.Predavac.ToString();

                ucUpravljajKursem.txtNazivKursa.ReadOnly = true;
                ucUpravljajKursem.txtTrajanje.ReadOnly = true;
                ucUpravljajKursem.txtOpis.ReadOnly = true;
                ucUpravljajKursem.txtPredavac.ReadOnly = true;
            }


            //dogadjaji
            ucUpravljajKursem.btnKreiraj.Click += KreirajKurs;
            ucUpravljajKursem.btnIzmeni.Click += IzmeniKurs;
            ucUpravljajKursem.btnObrisiKurs.Click += ObrisiKurs;
            ucUpravljajKursem.btnPrikaziSve.Click += (s, e) => GlavniKoordinator.Instance.PrikaziSveKurseve(FormMode.Prikazi);

            return ucUpravljajKursem;
        }

        private void ObrisiKurs(object sender, EventArgs e)
        {
            try
            {
                ucUpravljajKursem.lblNazivGreska.Visible = false;
                ucUpravljajKursem.lblPredavacGreska.Visible = false;
                ucUpravljajKursem.lblTrajanjeGreska.Visible = false;
                ucUpravljajKursem.lblOpisGreska.Visible = false;

                PreuzmiPodatkeOKursu();

                Komunikacija.Instance.ObrisiKurs(kurs);
                GlavniKoordinator.Instance.PrikaziSveKurseve(FormMode.Obrisi);

            }
            catch (KorisnickaGreska ex)
            {
                Console.WriteLine(ex.Poruka);
                GlavniKoordinator.Instance.PrikaziSveKurseve(FormMode.Obrisi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                GlavniKoordinator.Instance.PrikaziSveKurseve(FormMode.Obrisi);
            }
        }

        private void IzmeniKurs(object sender, EventArgs e)
        {
            try
            {
                ucUpravljajKursem.lblNazivGreska.Visible = false;
                ucUpravljajKursem.lblPredavacGreska.Visible = false;
                ucUpravljajKursem.lblTrajanjeGreska.Visible = false;
                ucUpravljajKursem.lblOpisGreska.Visible = false;

                PreuzmiPodatkeOKursu();

                Komunikacija.Instance.IzmeniKurs(kurs);
                GlavniKoordinator.Instance.PrikaziSveKurseve(FormMode.Izmeni);

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

        public void KreirajKurs(object sender, EventArgs e)
        {
            try
            {
                PreuzmiPodatkeOKursu();

                Komunikacija.Instance.KreirajKurs(kurs);

                ucUpravljajKursem.Dispose();

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

        private void PreuzmiPodatkeOKursu()
        {
            //obavezna polja
            if (ucUpravljajKursem.txtNazivKursa.Text == "")
            {
                ucUpravljajKursem.lblNazivGreska.Text = "Morate uneti naziv kursa";
                ucUpravljajKursem.lblNazivGreska.Visible = true;
                throw new KorisnickaGreska("greska >> naziv kursa");
            }
            if (ucUpravljajKursem.txtTrajanje.Text == "")
            {
                ucUpravljajKursem.lblTrajanjeGreska.Text = "Morate uneti trajanje kursa";
                ucUpravljajKursem.lblTrajanjeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> trajanje kursa");
            }
            if (ucUpravljajKursem.txtOpis.Text == "")
            {
                ucUpravljajKursem.lblOpisGreska.Text = "Morate uneti opis kursa";
                ucUpravljajKursem.lblOpisGreska.Visible = true;
                throw new KorisnickaGreska("greska >> opis kursa");
            }
            if (ucUpravljajKursem.cmbPredavaci.SelectedIndex < 0)
            {
                ucUpravljajKursem.lblPredavacGreska.Text = "Morate odabrati predavača";
                ucUpravljajKursem.lblPredavacGreska.Visible = true;
                throw new KorisnickaGreska("greska >> predavac");
            }

            //validna forma
            if (!ucUpravljajKursem.txtTrajanje.Text.All(x => char.IsDigit(x)))
            {
                ucUpravljajKursem.lblTrajanjeGreska.Text = "Trajanje kursa može da sadrži samo brojeve";
                ucUpravljajKursem.lblTrajanjeGreska.Visible = true;
                throw new KorisnickaGreska("greska >> trajanje kursa brojevi");
            }

            //max karaktera
            if (ucUpravljajKursem.txtNazivKursa.Text.Length > 50)
            {
                ucUpravljajKursem.lblNazivGreska.Text = "Naziv ne sme da ima više od 50 karaktera";
                ucUpravljajKursem.lblNazivGreska.Visible = true;
                throw new KorisnickaGreska("greska >> naziv kursa karakteri");
            }
            if (ucUpravljajKursem.txtOpis.Text.Length > 50)
            {
                ucUpravljajKursem.lblOpisGreska.Text = "Opis ne sme da ima više od 50 karaktera";
                ucUpravljajKursem.lblOpisGreska.Visible = true;
                throw new KorisnickaGreska("greska >> opis kursa karakteri");
            }

            kurs.NazivKursa = ucUpravljajKursem.txtNazivKursa.Text;
            kurs.OpisKursa = ucUpravljajKursem.txtOpis.Text;
            kurs.TrajanjeUMesecima = Int32.Parse(ucUpravljajKursem.txtTrajanje.Text);
            kurs.Predavac = (Predavac)ucUpravljajKursem.cmbPredavaci.SelectedItem;
            kurs.Zaposleni = GlavniKoordinator.Instance.ulogovaniZaposleni;
        }

        public UcPrikaziKurseve KreirajUcPrikaziKurseve(FormMode mode)
        {
            ucPrikaziKurseve = new UcPrikaziKurseve();

            ucPrikaziKurseve.dgvKursevi.DataSource = new BindingList<Kurs>(Komunikacija.Instance.VratiSveKurseve());
            ucPrikaziKurseve.dgvKursevi.Columns["opiskursa"].Visible = false;
            ucPrikaziKurseve.dgvKursevi.Columns["trajanjeumesecima"].HeaderText = "Trajanje u mesecima";
            ucPrikaziKurseve.dgvKursevi.Columns["nazivkursa"].HeaderText = "Naziv kursa";
            ucPrikaziKurseve.dgvKursevi.Columns["predavac"].HeaderText = "Predavač";

            if (mode == FormMode.Prikazi)
            {
                ucPrikaziKurseve.btnIzmeniKurs.Visible = false;
                ucPrikaziKurseve.btnObrisi.Visible = false;
            }

            if (mode == FormMode.Izmeni)
            {
                ucPrikaziKurseve.btnIzaberi.Visible = false;
                ucPrikaziKurseve.btnObrisi.Visible = false;
            }

            if (mode== FormMode.Obrisi)
            {
                ucPrikaziKurseve.btnIzmeniKurs.Visible = false;
                ucPrikaziKurseve.btnIzaberi.Visible = false;

            }

            //dogadjaji
            ucPrikaziKurseve.txtFilter.TextChanged += TxtFilterPretrazi;
            ucPrikaziKurseve.btnIzaberi.Click += IzaberiKursZaPrikaz;
            ucPrikaziKurseve.btnPrikaziSveKurseve.Click += PrikaziSveKurseve;
            ucPrikaziKurseve.btnIzmeniKurs.Click += IzaberiKursZaIzmenu;
            ucPrikaziKurseve.btnObrisi.Click += IzaberiKursZaBrisanje;

            return ucPrikaziKurseve;
        }

        private void IzaberiKursZaBrisanje(object sender, EventArgs e)
        {
            try 
            {
                if (ucPrikaziKurseve.dgvKursevi.SelectedRows.Count != 1)
                {
                    ucPrikaziKurseve.lblSelektovanUcenikGreska.Text = "Morate da odaberete jedan kurs";
                    ucPrikaziKurseve.lblSelektovanUcenikGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovan kurs");
                }

                Kurs kurs = (Kurs)ucPrikaziKurseve.dgvKursevi.SelectedRows[0].DataBoundItem;
                Kurs k = Komunikacija.Instance.VratiKurs(kurs);
                GlavniKoordinator.Instance.PrikaziKursZaBrisanje(k);

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

        private void IzaberiKursZaIzmenu(object sender, EventArgs e)
        {
            try
            {
                if (ucPrikaziKurseve.dgvKursevi.SelectedRows.Count != 1)
                {
                    ucPrikaziKurseve.lblSelektovanUcenikGreska.Text = "Morate da odaberete jedan kurs";
                    ucPrikaziKurseve.lblSelektovanUcenikGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovan kurs");
                }

                Kurs kurs = (Kurs)ucPrikaziKurseve.dgvKursevi.SelectedRows[0].DataBoundItem;
                Kurs k = Komunikacija.Instance.VratiKurs(kurs);
                GlavniKoordinator.Instance.PrikaziKursZaIzmenu(k);
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

        private void IzaberiKursZaPrikaz(object sender, EventArgs e)
        {
            try
            {

                if (ucPrikaziKurseve.dgvKursevi.SelectedRows.Count != 1)
                {
                    ucPrikaziKurseve.lblSelektovanUcenikGreska.Text = "Morate da odaberete jedan kurs";
                    ucPrikaziKurseve.lblSelektovanUcenikGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> selektovan kurs");
                }

                Kurs kurs = (Kurs)ucPrikaziKurseve.dgvKursevi.SelectedRows[0].DataBoundItem;
                Kurs k = Komunikacija.Instance.VratiKurs(kurs);
                GlavniKoordinator.Instance.PrikaziPodatkeOKursu(k);
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
                string filter = ucPrikaziKurseve.txtFilter.Text;
                if (filter.Length > 0)
                {
                    Kurs k = new Kurs()
                    {
                        KriterijumPretrage = $" lower(Kurs.nazivkursa) like '%{filter}%' or lower(p.prezime) like '{filter}%' or lower(p.ime) like '{filter}%' or lower(Kurs.korisnickoime) like lower('{filter}%')"
                    };
                    List<Kurs> filtriraniKursevi = Komunikacija.Instance.PretraziKurseve(k);
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
                ucPrikaziKurseve.txtFilter.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
