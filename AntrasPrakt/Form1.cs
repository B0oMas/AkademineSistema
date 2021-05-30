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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin")
             {
                menuStrip1.Visible = true;
                panel1.Visible = false;
             }
             else
             {
                MessageBox.Show("Klaidingi ivesti duomenys", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void naujasNaudotojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Naujas_naudotojas nn = new Naujas_naudotojas();
            nn.Show();
        }

        private void studentoPaieškaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IeskotiStudento IS = new IeskotiStudento();
            IS.Show();
        }

        private void naujasDėstytojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PridetiDestytoja pd = new PridetiDestytoja();
            pd.Show();
        }

        private void ieškotiDėstytojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IeskotiDestytojo id = new IeskotiDestytojo();
            id.Show();
        }

        private void pašalintiStudentąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IstrintiStudenta is1 = new IstrintiStudenta();
            is1.Show();
        }

        private void atsijungtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ar tikrai norite išeiti?", "Ar tikrai?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pašalintiDėstytojąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IstrintiDestytoja id1 = new IstrintiDestytoja();
            id1.Show();
        }

        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select vardas from dbo.Destytojas where vardas = '" + txtUsername.Text + "'select pavarde from dbo.Destytojas where pavarde = '" + txtPassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (txtUsername.Text == "Vardenis" && txtPassword.Text == "Pavardenis")
            {
                DestytojoForm dForm = new DestytojoForm();
                dForm.Show();
            }
            else
            {
                MessageBox.Show("Klaidingi ivesti duomenys", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pakeistiGrupeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PakeistiInfo pi = new PakeistiInfo();
            pi.Show();
        }

        private void btnStudentas_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select vardas from dbo.Naujas_naudotojas where vardas = '" + txtUsername.Text + "'select pavarde from dbo.Naujas_naudotojas where pavarde = '" + txtPassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(txtUsername.Text == "Lukas" && txtPassword.Text == "Anuzis")
            {
                StudentoForma sf = new StudentoForma();
                sf.Show();
            }
            else
            {
                MessageBox.Show("Klaidingi ivesti duomenys", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
