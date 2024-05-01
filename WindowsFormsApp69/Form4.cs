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
using System.Diagnostics;

namespace WindowsFormsApp69
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection cnd = new SqlConnection("Data Source=LAPTOP-TH19MO2H\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");


        SqlDataAdapter ADP;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from Bolgeler;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
             dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ADP.Update(dt);

        }

        private void NAKLİYECİBTN_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from Nakliyeciler;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }

        private void KATEGORİLERBTN_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from Kategoriler;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }

        private void MUSTERİLERBTN_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from Musteriler;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }

        private void SATİSDETAYLARIBTN_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from [satis detaylari];;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }

        private void SATISLARBTN_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from Satislar;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }

        private void TEDARİKCİLERBTN_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from Tedarikciler;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }

        private void URUNLER_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from urunler;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }

        private void PERSONELBTN_Click(object sender, EventArgs e)
        {

            ADP = new SqlDataAdapter("select * from Personeller;", cnd);

            SqlCommandBuilder cb = new SqlCommandBuilder(ADP);
            dt = new DataTable();
            ADP.Fill(dt);
            dataGridView1.DataSource= dt;
            ADP.Update(dt);
        }
    }
}
