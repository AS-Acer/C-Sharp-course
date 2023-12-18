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
    public partial class Admin_sayfası : Form
    {
        List<kisi> kisilerim;
        List<kitap> kitaplarım;
        public Admin_sayfası(List<kisi> kisilerim, List<kitap> kitaplarım)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;//admin sayfasından çağırdığımız kişileri buraya eşledik
            this.kitaplarım = kitaplarım;//aynı şekilde kitapları da eşledik

        }

        private void Admin_sayfası_Load(object sender, EventArgs e)
        {
            foreach (kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getGirisTarihi(), kisi.getUsername(), kisi.getSifre(), kisi.getYetki());
            }
            foreach (kitap kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapAd(), kitap.getKitapYazar(), kitap.getKitapDil(), kitap.getKitapYayınevi(), kitap.getKitapTur(), kitap.getAdet(), kitap.getSayfasayısı(), kitap.getBasımYılı());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //boxları hücrelere ekle
            dataGridView1.Rows.Add(Convert.ToInt32(txt_ara_id.Text), txt_isim.Text, txt_soyad.Text, maskedTextBox2.Text, txt_username.Text, txt_sifre.Text, txt_yetki.Text);
        }




        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_username.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();




        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            string id = txt_ara_id.Text;
            string isim = txt_isim.Text;
            string soyad = txt_soyad.Text;
            string tarih = maskedTextBox2.Text;
            string username = txt_username.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyad, tarih, username, sifre, yetki);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_k_ekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_k_id.Text, txt_k_isim.Text, txt_k_yazar.Text, txt_k_dil.Text, txt_k_yayınevi.Text, txt_k_tür.Text, txt_k_aded.Text, txt_k_sayfa.Text, txt_k_yıl.Text);
        }

        private void btn_k_sil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_k_gnclle_Click(object sender, EventArgs e)
        {
            //varolan değeri siliğ girilen değeri ekledik
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(txt_k_id.Text, txt_k_isim.Text, txt_k_yazar.Text, txt_k_dil.Text, txt_k_yayınevi.Text, txt_k_tür.Text, txt_k_aded.Text, txt_k_sayfa.Text, txt_k_yıl.Text);


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_k_temizle_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < groupBox2.Controls.Count; a++)
            {
                if (groupBox2.Controls[a] is TextBox)
                {
                    groupBox2.Controls[a].Text = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ara_id_Click(object sender, EventArgs e)
        {
            kisi hedefKisi = null;
            int secilenKisiId = Convert.ToInt32(txt_ara_id.Text);

            foreach (kisi kisi in kisilerim)
            {
                if (kisi.getId() == secilenKisiId)//secilen kisi ve yazılan id aynı ise hedefi kisileri yazdık
                {
                    hedefKisi = kisi;
                    break;
                }
            }
            foreach(kisi kisi in kisilerim)
            {
                if(kisi.getId()!= secilenKisiId)
                {
                    MessageBox.Show("Aradaığınız kişi numarası mevcud değildir .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
            
            
            foreach(kisi kisi in kisilerim)
            {
                if (hedefKisi == kisi)
                {
                    //sadece hedefi yaz gerisini sil
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getSoyisim(), hedefKisi.getGirisTarihi(), hedefKisi.getUsername(), hedefKisi.getSifre(), hedefKisi.getYetki());

                }
            }
            
        }

        private void btn_ara_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);//güncelleyince aynısından 2 tane olmasın diye ana olarak aldığımızı siliyoruz
            foreach (kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getSoyisim(), hedefKisi.getGirisTarihi(), hedefKisi.getUsername(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçilen satırı boxlara yazdır
            txt_k_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_k_isim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_k_yazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_k_dil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_k_yayınevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_k_tür.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_k_aded.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_k_sayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_k_yıl.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_k_ara_Click(object sender, EventArgs e)
        {
            kitap hedefKitap = null;
            int secilenKitapId = Convert.ToInt32(txt_k_ara.Text);

            foreach (kitap kitap in kitaplarım)
            {
                if (kitap.getKitapId() == secilenKitapId)//secilen kitap ve yazılan id aynı ise hedefi kisileri yazdık
                {
                    hedefKitap = kitap;
                    break;
                }
            }
            foreach (kitap kitap in kitaplarım)
            {
                if (kitap.getKitapId() != secilenKitapId)
                {
                    MessageBox.Show("Aradaığınız kitap mevcud değildir .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            foreach(kitap kitap in kitaplarım)
            {
                if (hedefKitap == kitap)
                {
                    //sadece hedefi yaz gerisini sil
                    dataGridView2.Rows.Clear();
                    dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapAd(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDil(), hedefKitap.getKitapYayınevi(), hedefKitap.getKitapTur(), hedefKitap.getAdet(), hedefKitap.getSayfasayısı(), hedefKitap.getBasımYılı());

                }
            }
              
        }

        private void btn_k_yenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);//güncelleyince aynısından 2 tane olmasın diye ana olarak aldığımızı siliyoruz
            foreach (kitap hedefKitap in kitaplarım)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapAd(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDil(), hedefKitap.getKitapYayınevi(), hedefKitap.getKitapTur(), hedefKitap.getAdet(), hedefKitap.getSayfasayısı(), hedefKitap.getBasımYılı());
            }
            
        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
            MessageBox.Show("Admin sayfasından çıkış yapıldı", "Yönlendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
