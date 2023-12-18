using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_soyisim_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyad = txt_soyisim.Text;

            dataGridView1.Rows.Add(id, isim, soyad);

            MessageBox.Show(" Ekleme başarılı ","Bilgilendirme" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1,"Ahmet","Acer");
            dataGridView1.Rows.Add(2,"Said","Acer");
            dataGridView1.Rows.Add(3,"Amet","Hknup");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyisim = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txt_id.Text = id;
            txt_isim.Text= isim;
            txt_soyisim.Text = soyisim;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            MessageBox.Show(" Silme işlemi başarılı  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_gnclle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyad = txt_soyisim.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyad);
            MessageBox.Show(" Güncelleme Başarılı ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
