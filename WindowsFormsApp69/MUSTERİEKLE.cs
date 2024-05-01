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
    public partial class MUSTERİEKLE : Form
    {
        public MUSTERİEKLE()
        {
            InitializeComponent();
        }
        SqlConnection cnd = new SqlConnection("Data Source=LAPTOP-TH19MO2H\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlCommand komut = new SqlCommand(@"insert into Musteriler (MusteriID,SirketAdi,MusteriAdi,MusteriUnvani,Adres,Sehir,Bolge,PostaKodu,Ulke,Telefon,Faks) 
                values ('" + textBox11.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+ textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"');",cnd);
            komut.ExecuteNonQuery();
            MessageBox.Show("veri başarı ile eklendi");

            cnd.Close();
           
        }

        private void MUSTERİEKLE_Load(object sender, EventArgs e)
        {
            cnd.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Musteriler;", cnd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource=dt;




            cnd.Close();
        }
    }
}
