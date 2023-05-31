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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            try {

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nisha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\testdb.mdf;Integrated Security=True;Connect Timeout=30");

                String sql = "insert into info(id) values ('" + id + "')";

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted");

                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        
        }
    }
}
