using Domen;
using Klijent.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmPrijavljivanje : Form
    {
        public FrmPrijavljivanje()
        {
            InitializeComponent();

            if (!Komunikacija.Instance.PoveziSe())
            {
                MessageBox.Show("Niste povezani na server!");
            }

        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = Komunikacija.Instance.UlogujSe(txtKorisnickoIme.Text, txtSifra.Text);
            if(odgovor.Signal== Signal.NeuspesnaPrijava)
            {
                MessageBox.Show("Neuspesno prijavljivanje na sistem");
                return;
            }

            MessageBox.Show("Uspesno ste prijavljeni");
            FrmZaposleni forma = new FrmZaposleni(odgovor.Zaposleni);
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }
    }
}
