using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }
        int sayi = 20;//saniye değerini girdik

        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;//zamanlamayı aktif yaptık
            timer3.Enabled = true;//sayacı aktif yaptık
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //saniyede -1 artacak

            if (sayi >= 0)
            {
                lbl_deger.Text = sayi.ToString();
                sayi--;
            }
            else
            {
                timer1.Enabled=false;
            }
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled= true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text= DateTime.Now.Hour.ToString();
            lbl_dk.Text= DateTime.Now.Minute.ToString();
            lbl_saniye.Text=DateTime.Now.Second.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer3.Enabled = false; 
            }

        }
    }
}
