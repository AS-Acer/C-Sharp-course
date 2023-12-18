using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuStripKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stockSayfasınaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock_sayfası pagem = new stock_sayfası();//yeni sayfa oluşturduk
            pagem.Show();//sayfayı açtık
            this.Hide();// eskiyi kapadık
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamayı kapadık
                
        }
    }
}
