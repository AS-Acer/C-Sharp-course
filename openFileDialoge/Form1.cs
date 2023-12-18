using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openFileDialoge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string resimYolu = openFileDialog1.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            //veriler veri tabınında gönderildi sonuçla devam :
            MessageBox.Show("Kayıt başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //messagbox gösterildikten sonra kayıt sıfırlama için :

            for (int i = 0; i < groupBox1.Controls.Count; i++)//groupbox uzunluğunca dönsün
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is RichTextBox || groupBox1.Controls[i] is MaskedTextBox)//eğer textbox veya richtextbox is
                {
                    groupBox1.Controls[i].Text = string.Empty; //textbox.text ve richbox.textdeğerini boşalt   
                    
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image =Image.FromFile(openFileDialog1.FileName);
        }

        private void lbl_ad_Click(object sender, EventArgs e)
        {

        }
    }
}
