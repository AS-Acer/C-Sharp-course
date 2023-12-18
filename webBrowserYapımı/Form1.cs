using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowserYapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_rfrsh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }
    }
}
