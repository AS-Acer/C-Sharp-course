using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void combo_gunler_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_gnSec_MouseClick(object sender, MouseEventArgs e)
        { 
            string secilengun = combo_gunler.SelectedItem.ToString();
            MessageBox.Show("Seçilen gün : "+secilengun);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_gunsec_Click(object sender, EventArgs e)
        {

        }
    }
}
