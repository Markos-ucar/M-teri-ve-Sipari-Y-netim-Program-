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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cnd = new SqlConnection(@"Data Source=LAPTOP-TH19MO2H\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM BOLGE;",cnd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource =dt;

           
       
        }

        private void sehirbtn_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Bolgeler;",cnd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource =dt;

           

        }

        private void KATEGORİBTN_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Kategoriler;", cnd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource=dt;


            cnd.Close();
        }

        private void musteribtn_Click(object sender, EventArgs e)
        {
            cnd.Open();
            
            SqlDataAdapter adp = new SqlDataAdapter("SELECT *FROM Musteriler;",cnd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource=dt;
            cnd.Close();
        }

        private void MUSTERİDEMOBTN_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter ADP = new SqlDataAdapter("SELECT * FROM MusteriMusteriDemo; ", cnd);
            DataTable dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource =dt;
            cnd.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter ADP = new SqlDataAdapter("select *from Nakliyeciler",cnd);
            DataTable dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource=dt;
            
            cnd.Close();
        }

        private void personelbtn_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Personeller",cnd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            cnd.Close();
        }

        private void satisdetayleribtn_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter ADP = new SqlDataAdapter("select * from [Satis Detaylari];", cnd);

            DataTable dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource=dt;
            cnd.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Satislar",cnd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource=dt;

            cnd.Close();
        }

        private void TEDARİKCİLERBTN_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter ADP = new SqlDataAdapter("select * from Tedarikciler",cnd);
            DataTable dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource=dt;

            cnd.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter ADP = new SqlDataAdapter("SELECT * FROM Urunler",cnd);

            DataTable dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource=dt;

            cnd.Close();

        }
    }
}
