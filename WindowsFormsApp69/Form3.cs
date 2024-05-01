using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp69
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void kategrorieklebtn_Click(object sender, EventArgs e)
        {
            KATEGORİ_EKLE kategoriekle = new KATEGORİ_EKLE();
            kategoriekle.Show();
        }

        private void MUSTERİEKLEBTN_Click(object sender, EventArgs e)
        {
            MUSTERİEKLE MUSTERİEKLE = new MUSTERİEKLE();
            MUSTERİEKLE.Show();
        }

        private void NAKLİYECİEKLEBTN_Click(object sender, EventArgs e)
        {
            NAKLİYECİEKLE nakliyeciekle = new NAKLİYECİEKLE();
            nakliyeciekle.Show();

        }

        private void PERSONELEKLEBTN_Click(object sender, EventArgs e)
        {
            PERSONELEKLE personelekle = new PERSONELEKLE();
            personelekle.Show();
        }

        private void SATİSEKLEBTN_Click(object sender, EventArgs e)
        {
            TEDARİKCİEKLE tedarikciekle = new TEDARİKCİEKLE();
            tedarikciekle.Show();

        }
    }
}
