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
    public partial class PERSONELEKLE : Form
    {
        public PERSONELEKLE()
        {
            InitializeComponent();
        }
        //veri eklemedi sorun oluştu. sütün sayılarının fazla oldugu soyleniyor.
        
        SqlConnection CND = new SqlConnection("Data Source=LAPTOP-TH19MO2H\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
        private void PERSONELEKLE_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Personeller",CND);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CND.Open();

            SqlCommand KOMUT = new SqlCommand("insert into Personeller(SoyAdi,Adi,Unvan,unvaneki,Adres,Sehir,Bolge,PostaKodu,Ulke,EvTelefonu,Extension,Notlar,BagliCalistigiKisi,FotografPath) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"','"+textBox11.Text+"','"+textBox12.Text+"','"+textBox13.Text+"','"+textBox14.Text+"')", CND);
            
            if (KOMUT.ExecuteNonQuery()==1)
            {
                MessageBox.Show("VERİ EKLENDİ");
            }
            else
            {
                MessageBox.Show("veri eklenmedi");
            }


            CND.Close();
        }
    }
}
