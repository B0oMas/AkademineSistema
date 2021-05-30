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
    public partial class IeskotiStudento : Form
    {
        public IeskotiStudento()
        {
            InitializeComponent();
        }

        private void IeskotiStudento_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select dbo.Naujas_naudotojas.NNID as Studento_ID, dbo.Naujas_naudotojas.vardas as Vardas, dbo.Naujas_naudotojas.pavarde as Pavarde, dbo.Naujas_naudotojas.gimimodata as Gimimo_Data, dbo.Naujas_naudotojas.telnr as Tel_Nr, dbo.Naujas_naudotojas.studijupavad as Studiju_pav, dbo.Naujas_naudotojas.grupe as Grupe, dbo.Naujas_naudotojas.adresas as Adresas, dbo.Naujas_naudotojas.elpastas as El_pastas from dbo.Naujas_naudotojas";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = .; database = MokyklaDB; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from dbo.Naujas_naudotojas where NNID = " + textBoxSearchID.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
