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


namespace WindowsFormsApp69
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection cnd = new SqlConnection("Data Source=LAPTOP-TH19MO2H\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");

        SqlDataAdapter adp;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
             adp = new SqlDataAdapter("select *from Bolgeler",cnd);
             SqlCommandBuilder cb = new SqlCommandBuilder(adp);
             dt = new DataTable();
             
            adp.Fill(dt);

            dataGridView1.DataSource =dt;




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adp.Update(dt);

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            adp = new SqlDataAdapter("select * from Kategoriler;", cnd);
         
            dt = new DataTable();

            SqlCommandBuilder cb = new SqlCommandBuilder(adp);
            adp.Fill(dt);
            dataGridView1.DataSource=dt;


        }

        private void button3_Click(object sender, EventArgs e)
        {
          adp = new SqlDataAdapter("SELECT * FROM Musteriler",cnd);
            SqlCommandBuilder CMD = new SqlCommandBuilder(adp);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource =dt;
           


        }

        private void button4_Click(object sender, EventArgs e)
        {

            adp = new SqlDataAdapter("select *from Nakliyeciler",cnd);
            dt=new DataTable();
            SqlCommandBuilder CMD = new SqlCommandBuilder(adp);
            adp.Fill(dt);
            dataGridView1.DataSource=dt;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from Personeller",cnd);
            dt = new DataTable();
            SqlCommandBuilder cb = new SqlCommandBuilder(adp);


            adp.Fill(dt);

            dataGridView1.DataSource=dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("SELECT * FROM Satislar",cnd);
            dt = new DataTable();
            SqlCommandBuilder cn = new SqlCommandBuilder(adp);

            adp.Fill(dt);
            dataGridView1.DataSource = dt;






        }

        private void button7_Click(object sender, EventArgs e)
        {



         
                adp = new SqlDataAdapter("select * from Tedarikciler", cnd);
                dt = new DataTable();

                SqlCommandBuilder cb = new SqlCommandBuilder(adp);

                adp.Fill(dt);
                dataGridView1.DataSource=dt;



        }

        private void button8_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from Urunler",cnd);
            dt = new DataTable();

            SqlCommandBuilder cb = new SqlCommandBuilder(adp);

            adp.Fill(dt);
            dataGridView1.DataSource=dt;




        }
    }
}
