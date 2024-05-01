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
    public partial class ÜRÜNEKLEME : Form
    {
        public ÜRÜNEKLEME()
        {
            InitializeComponent();
        }
        SqlConnection CND = new SqlConnection("");
        // primary key ile foreign keyi ogrendikten sonra numa bak


        private void button1_Click(object sender, EventArgs e)
        {
            CND.Open();
            SqlCommand komut = new SqlCommand("",CND);


            CND.Close();



        }
    }
}
