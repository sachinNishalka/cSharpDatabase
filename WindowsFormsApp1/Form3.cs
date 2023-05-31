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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nisha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\testdb.mdf;Integrated Security=True;Connect Timeout=30");
                string sql = "select * from info";
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();

                da.Fill(ds, "data");
                dataGridView1.DataSource = ds.Tables["data"];
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }
    }
}
