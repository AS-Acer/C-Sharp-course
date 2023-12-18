using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet =" ";//değerleri boş atadık
            ad =txt_ad.Text;
            soyad = txt_soyad.Text;

            if(radio_erkek.Checked )
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }
            MessageBox.Show("Ad Soyad : " + ad + " " + soyad     + "\n" + "Cinsiyet : " + cinsiyet,"Bilgiler ",MessageBoxButtons.OK,MessageBoxIcon.Information); 
                
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
