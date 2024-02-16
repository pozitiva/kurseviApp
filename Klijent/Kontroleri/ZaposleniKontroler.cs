using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class ZaposleniKontroler
    {
        FrmPrijavljivanje frmPrijavljivanje;

        public void KreirajFrmPrijavljivanje(FrmPrijavljivanje frmPrijavljivanje)
        {
            this.frmPrijavljivanje = frmPrijavljivanje;
            frmPrijavljivanje.btnPrijaviSe.Click += BtnPrijaviSeNaKlik;
        }

        public void OdjaviZaposlenog(Zaposleni ulogovaniZaposleni)
        {
            Komunikacija.Instance.OdjaviZaposlenog(ulogovaniZaposleni);
        }

        private void BtnPrijaviSeNaKlik(object sender, EventArgs e)
        {
            //try
            //{
                //prazna polja
                if (frmPrijavljivanje.txtKorisnickoIme.Text == "" && frmPrijavljivanje.txtSifra.Text == "")
                {
                    frmPrijavljivanje.lblImeGreska.Text = "Morate uneti korisnicko ime";
                    frmPrijavljivanje.lblImeGreska.Visible = true;
                    frmPrijavljivanje.lblSifraGreska.Text = "Morate uneti šifru";
                    frmPrijavljivanje.lblSifraGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> korisnicko ime i sifra");
                }
                if (frmPrijavljivanje.txtKorisnickoIme.Text == "")
                {
                    frmPrijavljivanje.lblImeGreska.Text = "Morate uneti korisnicko ime";
                    frmPrijavljivanje.lblImeGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> korisnicko ime");
                }
                if (frmPrijavljivanje.txtSifra.Text == "")
                {
                    frmPrijavljivanje.lblSifraGreska.Text = "Morate uneti šifru";
                    frmPrijavljivanje.lblSifraGreska.Visible = true;
                    throw new KorisnickaGreska("greska >> sifra");
                }

                Zaposleni zaposleni = PreuzmiPodatkeZaposlenog();
                zaposleni = Komunikacija.Instance.UlogujSe(zaposleni);
                if(zaposleni != null)
                {
                    MessageBox.Show("Uspesno ste prijavljeni");
                    GlavniKoordinator.Instance.ulogovaniZaposleni = zaposleni;
                    GlavniKoordinator.Instance.PrikaziFrmZaposleni();
                }
                else
                {
                    MessageBox.Show("Neuspesno prijavljivanje na sistem");
                    return;
                }
            //}
            //catch (KorisnickaGreska ex)
            //{
            //    Console.WriteLine(ex.Poruka);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }

        private Zaposleni PreuzmiPodatkeZaposlenog()
        {
            Zaposleni zaposleni = new Zaposleni
            {
                KorisnickoIme = frmPrijavljivanje.txtKorisnickoIme.Text,
                Sifra = frmPrijavljivanje.txtSifra.Text
            };
            return zaposleni;
        } 
    }
}
