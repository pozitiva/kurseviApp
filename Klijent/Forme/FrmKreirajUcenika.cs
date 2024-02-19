using Klijent.Kontroleri;
using Klijent.KorisnickeKontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Klijent.Forme
{
    public partial class FrmKreirajUcenika : Form
    {
        public FrmKreirajUcenika()
        {
            InitializeComponent();

        }

        public void PromeniPanel(System.Windows.Forms.Control control)
        {
            pnlKreirajUcenika.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlKreirajUcenika.Controls.Add(control);
        }

        private void FrmKreirajUcenika_Load(object sender, EventArgs e)
        {
            GlavniKoordinator.Instance.PrikaziKreirajUcenikaNaFormi();
        }
    }
}
