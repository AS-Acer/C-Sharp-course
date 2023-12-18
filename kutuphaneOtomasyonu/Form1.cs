using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        List<kitap> kitaplarım = new List<kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1, "Ahmet", "Acer", DateTime.Now, "ahmet", "12345", "admin"));
            kisilerim.Add(new kisi(2, "Nuri", "Çalışkan", DateTime.Now, "nuri", "12345", "üye"));
            kisilerim.Add(new kisi(3, "Ahmet", "Gümüş", DateTime.Now, "enes", "12345", "üye"));

            kitaplarım.Add(new kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "YKY", "roman", 100, 250, 2016));
            kitaplarım.Add(new kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 350, 760, 2015));
            kitaplarım.Add(new kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "roman", 100, 350, 2010));



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            txt_ad.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            
            
            string username, sifre = string.Empty;

            username = txt_ad.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;

            foreach (kisi kisi in kisilerim)
            {
                if (username.ToLower() == kisi.getUsername() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                    //admin sayfası aç
                    Admin_sayfası administration = new Admin_sayfası(kisilerim,kitaplarım);
                    administration.Show();
                    this.Hide();
                    kontrol = true;

                }
                else if (username.ToLower() == kisi.getUsername() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "üye")
                {
                    //üye sayfası aç
                    Üye_sayfası membership = new Üye_sayfası(kitaplarım);
                    membership.Show();
                    this.Hide();
                    kontrol = true;


                }

            }
            if (!kontrol)
            {
                MessageBox.Show("Hata !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ad_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ad.Text = string.Empty;
        }

        private void txt_sifre_MouseClick(object sender, MouseEventArgs e)
        {
            txt_sifre.Text = string.Empty;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
      
        }

        private void btn_giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_giris.PerformClick();
            }
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
