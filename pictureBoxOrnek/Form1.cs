using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBoxOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı, sifre = " ";

            kullanıcıAdı = txt_Ad.Text;
            sifre = txt_sifre.Text;

            if (kullanıcıAdı.ToLower() == "ahmet" && sifre == "1")
            {
                //farklı forma gönderme
                anasayfa ana = new anasayfa();
                ana.lbl_ana_deger.Text = kullanıcıAdı.ToUpper();
                ana.Show();

                //this.hide ile varolan formu yeni form açılınca kapat
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
