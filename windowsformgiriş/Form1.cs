using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformgiriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formumuz çalışınca bu metot çalışır 
            


            //lbl_deger.Text = "AhmetSaid";// lbl_degere isim atadık


        }

        private void txt_birinciNot_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double  ortalama = (Convert.ToDouble(txt_birinciNot.Text) + Convert.ToDouble(txt_ikinciNot.Text)) / 2;
            lbl_ortalamaSonuc.Text=ortalama.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
