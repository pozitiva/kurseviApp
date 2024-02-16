using Domen;
using Klijent.Forme;
using Klijent.Kontroleri;
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

            MessageBox.Show("Sistem ne moze da ucita kurs");

            txtKorisnickoIme.Text = "iva";
            txtSifra.Text = "iva";

        }
    }
}
