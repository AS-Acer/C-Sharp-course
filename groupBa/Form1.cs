using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupBa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //veriler veri tabınında gönderildi sonuçla devam :
            MessageBox.Show("Kayıt başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            //messagbox gösterildikten sonra kayıt sıfırlama için :
            
            for(int i = 0; i < groupBox1.Controls.Count; i++)//groupbox uzunluğunca dönsün
            {
                if (groupBox1.Controls[i] is TextBox)//eğer textboxsa 
                {
                    groupBox1.Controls[i].Text = string.Empty; //textbox.text değerini boşalt   
                }
            }
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ad_Click(object sender, EventArgs e)
        {

        }

        private void lbl_soyad_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tel_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mail_Click(object sender, EventArgs e)
        {

        }

        private void lbl_il_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_erkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
