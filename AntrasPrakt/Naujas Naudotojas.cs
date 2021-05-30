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
    public partial class Naujas_naudotojas : Form
    {
        public Naujas_naudotojas()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string vardas = txtVardas.Text;
            string pavarde = txtPavarde.Text;
            string lytis = "";
            bool isChecked = radioButtonVyras.Checked;
            if(isChecked) // jei pirmas pazymetas tai vyras, jei antras tai moteris
            {
                lytis = radioButtonVyras.Text;
            }
            else
            {
                lytis = radioButtonMoteris.Text;
            }
            string dob = dateTimePickerDOB.Text; // dateofbirth
            string telnr = txtTelNr.Text;
            string fakultetas = txtFakultetas.Text;
            string studijupav = txtStudijuPav.Text;
            string grupe = txtGrupe.Text;
            string adresas = txtAdresas.Text;
            string elpastas = txtPastas.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into dbo.Naujas_naudotojas (NNID, vardas, pavarde, lytis, gimimodata, telnr, fakultetas, studijupavad, grupe, adresas, elpastas) values ('" + ID + "', '" + vardas + "', '" + pavarde + "', '" + lytis + "', '" + dob + "', '" + telnr + "', '" + fakultetas + "', '" + studijupav + "', '" + grupe + "', '" + adresas + "', '" + elpastas + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Informacija išsaugota. Neužmirškite ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtVardas.Text = "";
            txtPavarde.Text = "";
            dateTimePickerDOB.Text = "";
            txtTelNr.Text = "";
            txtFakultetas.Text = "";
            txtStudijuPav.Text = "";
            txtGrupe.Text = "";
            txtAdresas.Text = "";
            txtPastas.Text = "";

        }

        private void Naujas_naudotojas_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(NNID) from dbo.Naujas_naudotojas";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            txtID.Text = (abc + 1).ToString();

        }
    }
}
