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

namespace ForoPrac1
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog =DBPrac1; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("conexion creada con exito");
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query ="Select  * from dbo.Apoderado";
                cmd = new SqlCommand(query, con);
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
    }
}
