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
    public partial class PridetiDestytoja : Form
    {
        public PridetiDestytoja()
        {
            InitializeComponent();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string lytis = "";
            bool isChecked = radioButton1.Checked;

            if(isChecked)
            {
                lytis = radioButton1.Text;
            }

            else
            {
                lytis = radioButton2.Text;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into dbo.Destytojas (dID, vardas, pavarde, lytis, gimimoData, elpastas, telnr, desto, adresas) values ('"+ txtdID.Text + "','"+ txtVardas.Text + "', '" + txtPavarde.Text + "', '" + lytis + "', '" + dateTimePicker1.Text + "', "+txtTel_Nr.Text+", '"+ txtEl_Pastas.Text + "', '" + comboBox1.Text + "', '" + txtAdresas.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Informacija išsaugota", "Sekmingai pridėta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PridetiDestytoja_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(dID) from dbo.Destytojas";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            txtdID.Text = (abc + 1).ToString();
        }
    }
}
