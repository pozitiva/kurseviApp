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

        private void BtnPrijaviSeNaKlik(object sender, EventArgs e)
        {
            try
            {
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

                //tekstualna polja
                //if (frmPrijavljivanje.txtKorisnickoIme.GetType() != typeof(string))
                //{
                //    frmPrijavljivanje.lblImeGreska.Text = "Korisnicko ime mora biti tekst";
                //    frmPrijavljivanje.lblImeGreska.Visible = true;
                //    throw new KorisnickaGreska("greska >> korisnicko ime tekst");
                //}

                //if (frmPrijavljivanje.txtSifra.GetType() != typeof(string))
                //{
                //    frmPrijavljivanje.lblSifraGreska.Text = "Sifra mora biti tekst";
                //    frmPrijavljivanje.lblSifraGreska.Visible = true;
                //    throw new KorisnickaGreska("greska >> sifra tekst");
                //}


                Zaposleni zaposleni = PreuzmiPodatkeZaposlenog();
                zaposleni = Komunikacija.Instance.UlogujSe(zaposleni);
                GlavniKoordinator.Instance.ulogovaniZaposleni = zaposleni;
                GlavniKoordinator.Instance.PrikaziFrmZaposleni();
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
