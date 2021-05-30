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
    public partial class PakeistiInfo : Form
    {
        public PakeistiInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite pakeisti grupe?", "Pavirtinti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select NNID from dbo.Naujas_naudotojas where NNID = '" + textBoxID.Text + "' update dbo.Naujas_naudotojas set studijupavad = '" + comboBoxTo.Text + "' where studijupavad = '" + comboBoxFrom.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Sekmingai pakeista");
            }
            else
            {
                MessageBox.Show("Pakeitimas atsauktas");
            }
        }
    }
}
