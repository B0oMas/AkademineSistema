using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrasPrakt
{
    public partial class DestytojoForm : Form
    {
        public DestytojoForm()
        {
            InitializeComponent();
        }

        private void įvestiPažymįToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IvestiPazymi ip = new IvestiPazymi();
            ip.Show();
        }

        private void pakeistiPažymįToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PakeistiPazymi Pp = new PakeistiPazymi();
            Pp.Show();
        }

        private void atsijungtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išeiti?", "Ar tikrai?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
