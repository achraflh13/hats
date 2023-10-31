using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appd
{
    public partial class Form1 : Form
    {
        string con = "Data Source=.;Initial Catalog=gestion_ecoled;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        SqlConnection connection;
        SqlCommand command;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(con);
            connection.Open();


            dataAdapter = new SqlDataAdapter("SELECT*FROM gestion_ecoledd", con);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            tableau.DataSource = dt;
        }
    }
}
