using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string gun = txt_degerGir.Text;
            listBox1.Items.Add(gun);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string silinecekgun = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(silinecekgun);
        }

        private void btn_countBul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count değeri : "+ listBox1.Items.Count.ToString(),"Count sonuç ",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            MessageBox.Show("Listbox temizlendi ", "TEMİZLİK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
