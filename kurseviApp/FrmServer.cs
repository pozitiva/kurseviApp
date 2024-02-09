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
        public FrmServer()
        {
            InitializeComponent();   
            btnPrekini.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Server.Instance.pokrenutServer) Server.Instance.Pokreni();
                btnPrekini.Enabled = true;
                btnPokreni.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrekini_Click(object sender, EventArgs e)
        {
            try
            {
                if (Server.Instance.pokrenutServer) Server.Instance.Prekini();
                btnPrekini.Enabled = false;
                btnPokreni.Enabled = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
