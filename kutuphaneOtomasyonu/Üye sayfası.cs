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
    public partial class Üye_sayfası : Form
    {
        List<kitap> kitaplarım;
        public Üye_sayfası(List<kitap> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarım = kitaplarım;
        }

        private void btn_üye_ara_Click(object sender, EventArgs e)
        {
            kitap hedefKitap = null;
            string secilenKitapAd = (txt_üye_ara.Text);


            foreach (kitap kitap in kitaplarım)
            {
                if (kitap.getKitapAd().ToLower() == secilenKitapAd)//secilen kitap ve yazılan isim aynı ise hedefi kisileri yazdık
                {

                    hedefKitap = kitap;
                    break;
                }

            }
            foreach (kitap kitap in kitaplarım)
            {
                if (kitap.getKitapAd().ToLower() != secilenKitapAd)
                {
                    MessageBox.Show("Aradaığınız kitap mevcud değildir .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                break;
            }
            foreach (kitap kitap in kitaplarım)
            {
                if (hedefKitap == kitap)
                {
                    //sadece hedefi yaz gerisini sil
                    dataGridView2.Rows.Clear();
                    dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapAd(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDil(), hedefKitap.getKitapYayınevi(), hedefKitap.getKitapTur(), hedefKitap.getAdet(), hedefKitap.getSayfasayısı(), hedefKitap.getBasımYılı());

                    break;
                }
            }
        }

        private void btn_üye_çıkış_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();

            MessageBox.Show("Üye işlemleri sayfasından çıkış yapıldı.", "Yönlendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Üye_sayfası_Load(object sender, EventArgs e)
        {
            foreach (kitap kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapAd(), kitap.getKitapYazar(), kitap.getKitapDil(), kitap.getKitapYayınevi(), kitap.getKitapTur(), kitap.getAdet(), kitap.getSayfasayısı(), kitap.getBasımYılı());
            }

        }

        private void btn_üye_yenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);//güncelleyince aynısından 2 tane olmasın diye ana olarak aldığımızı siliyoruz
            foreach (kitap hedefKitap in kitaplarım)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapAd(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDil(), hedefKitap.getKitapYayınevi(), hedefKitap.getKitapTur(), hedefKitap.getAdet(), hedefKitap.getSayfasayısı(), hedefKitap.getBasımYılı());
            }
        }
    }
}
