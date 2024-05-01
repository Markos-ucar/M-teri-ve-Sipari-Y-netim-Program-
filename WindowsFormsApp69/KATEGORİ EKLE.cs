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

namespace WindowsFormsApp69
{
    public partial class KATEGORİ_EKLE : Form
    {
        public KATEGORİ_EKLE()
        {
            InitializeComponent();
        }
        SqlConnection cnd = new SqlConnection("Data Source=LAPTOP-TH19MO2H\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            cnd.Open();
            SqlCommand komut = new SqlCommand("insert into Kategoriler (KategoriAdi,Tanimi) values('"+textBox2.Text+"','"+ textBox3.Text+"');", cnd);
            
            MessageBox.Show("bir veri eklendi"+komut.ExecuteNonQuery());

            cnd.Close();

        }
    }
}
