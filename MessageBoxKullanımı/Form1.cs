using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istiyor musunuz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (sonuc == DialogResult.Yes)
            {
                lbl_sonuc.Text = "Çıkış yapılıyor. ";

            }
            else
            {
                lbl_sonuc.Text = "Çıkış yapılmadı.";
            }

        }
    }
}
