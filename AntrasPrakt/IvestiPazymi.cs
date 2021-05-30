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
    public partial class IvestiPazymi : Form
    {
        public IvestiPazymi()
        {
            InitializeComponent();
        }

        private void IvestiPazymi_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from dbo.Naujas_naudotojas";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "select max(pID) from dbo.Pazymis";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            textBox5.Text = (abc + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite įvesti pažymį?", "Ispėjimas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into dbo.Pazymis (pID, pazymys, vardas, pavarde, studpavad, grupe) values ('" + textBox5.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "')";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Sėkmingai įvertinote");
            }
        }
    }
}
