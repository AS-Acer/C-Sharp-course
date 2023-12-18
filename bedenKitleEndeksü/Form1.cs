using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bedenKitleEndeksü
{
    public partial class Form1 : Form 
    {
        List<persons> persons= new List<persons>();//anasayfaya kişileri çağırdım
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            double boy =Convert.ToDouble(txt_boy.Text);
            int kilo = Convert.ToInt32(txt_kg.Text);
            string ad = txt_id.Text;
            string soyad = txt_surname.Text;

            double sonuç = (kilo / (boy * boy));
            lbl_sonuc.Text = sonuç.ToString();
            

            




            string indeks;
            if (sonuç <= 18)
            {
                indeks = " zayıf";
            }
            else if (sonuç > 18 && sonuç <= 35)
            {
                indeks = " normal ";
            }
            else
            {
                indeks = " obez";
            }

            MessageBox.Show(ad + " " + soyad + " beden kitle endeks puanınız : " + indeks + "değer aralığında : " + sonuç, "sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Rows.Add(txt_id.Text, txt_name.Text,txt_surname.Text,txt_boy.Text, txt_kg.Text,lbl_sonuc.Text);
        
        }

        
        


        private void Form1_Load(object sender, EventArgs e)
        {
            persons.Add(new persons(1, "Ahmet Said", "Acer", 76, 1.84,"22,244"));
            persons.Add(new persons(2, "Oğuzhan", "Kodal", 76, 1.77,"24,258456"));



            foreach (persons persons in persons)
            {
                dataGridView1.Rows.Add(persons.getId(),persons.getName(),persons.getSurname(),persons.getWeight(),persons.getTall(),persons.getİndeks());
            }



            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_sonuc_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

        }

        private void btn_gnclle_Click(object sender, EventArgs e)
        {

            string id = txt_id.Text;
            string isim = txt_name.Text;
            string soyad = txt_surname.Text;
            int weight =   Convert.ToInt32(txt_kg.Text);
            double tall = Convert.ToDouble(txt_boy.Text);
            
            
            

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyad,weight,tall);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // İlgili hücreye tıklandığında tüm satırı seç
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }

            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_kg.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_boy.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lbl_sonuc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        { 
   
        }
    }
}
