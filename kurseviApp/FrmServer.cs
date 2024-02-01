using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurseviApp
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            s= new Server();    
            btnPrekini.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            Thread nit = new Thread(s.Pokreni);
            nit.IsBackground = true;
            nit.Start();

            btnPrekini.Enabled = true;
            btnPokreni.Enabled = false;
        }

        private void btnPrekini_Click(object sender, EventArgs e)
        {
            s.Prekini();
            btnPrekini.Enabled= false;
            btnPokreni.Enabled = true;
        }
    }
}
