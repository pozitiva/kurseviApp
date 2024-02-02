using Domen;
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

namespace Klijent.Forme
{
    public partial class FrmZaposleni : Form
    {
        Zaposleni ulogovaniZaposleni;
        public FrmZaposleni(Zaposleni zaposleni)
        {
            InitializeComponent();
            ulogovaniZaposleni = zaposleni;
            lblZaposleni.Text = ulogovaniZaposleni.KorisnickoIme;

            this.kreirajKursToolStripMenuItem.Click += (s, e) => GlavniKoordinator.Instance.PrikaziKreirajKurs(ulogovaniZaposleni);
        }

        public void PromeniPanel(Control control)
        {
            pnlGlavna.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlGlavna.Controls.Add(control);
        }
    }
}
