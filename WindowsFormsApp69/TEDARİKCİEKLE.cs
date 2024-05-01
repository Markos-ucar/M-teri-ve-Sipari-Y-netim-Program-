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
    public partial class TEDARİKCİEKLE : Form
    {
        public TEDARİKCİEKLE()
        {
            InitializeComponent();
        }
        SqlConnection CND = new SqlConnection("Data Source=LAPTOP-TH19MO2H\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            CND.Open();
            SqlCommand KOMUT = new SqlCommand("insert into Tedarikciler(SirketAdi,MusteriAdi,MusteriUnvani,Adres,Sehir,Bolge,PostaKodu,Ulke,Telefon,Faks,WebSayfasi) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"','"+textBox11.Text+"');", CND);

            KOMUT.ExecuteNonQuery();

            MessageBox.Show("YENİ TEDARİKCİ EKLENDİ");







            CND.Close();

        }
    }
}
