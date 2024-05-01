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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 vgöster = new Form2();
            vgöster.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 vekle = new Form3();
            vekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 vsil = new Form4();
            vsil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 vgüncelleme = new Form5();
            vgüncelleme.Show();
        }
    }
}
