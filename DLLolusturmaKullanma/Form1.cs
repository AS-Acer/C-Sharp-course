using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matematik;//matematik adındaki kendi oluşturduğum kütüphaneyi ekledim

namespace DLLolusturmaKullanma
{
    public partial class Form1 : Form
    {
        matematikislemleri matislem = new matematikislemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(txt_sayı_1.Text);
            int sayı2 = Convert.ToInt32(txt_sayı_2.Text);
            int toplam =matislem.toplama(sayı1, sayı2);          
            lbl_sonuc.Text = toplam.ToString();
        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(txt_sayı_1.Text);
            int sayı2 = Convert.ToInt32(txt_sayı_2.Text);
           int toplam = matislem.cıkar(sayı1, sayı2);
            lbl_sonuc.Text = toplam.ToString();


        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(txt_sayı_1.Text);
            int sayı2 = Convert.ToInt32(txt_sayı_2.Text);
            int toplam = matislem.carpma(sayı1, sayı2);
            lbl_sonuc.Text = toplam.ToString();
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(txt_sayı_1.Text);
            int sayı2 = Convert.ToInt32(txt_sayı_2.Text);
            double   toplam = matislem.bolme(sayı1, sayı2);
            lbl_sonuc.Text = toplam.ToString();
        }
    }
}
