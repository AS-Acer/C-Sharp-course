using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int score = 0;
        int roadspeed = 5;
        int owncarspeed = 5; // bizim arabanın hızı
        int othercarsspeed = 5; //dier arabanın hızı 
        Random rnd =new Random();
        bool right = false;
        bool left = false;  

        public void oyunuBaşlat()
        {
            btn_start.Enabled = false;
            explasion.Visible = false;

            owncarspeed = 15;
            othercarsspeed = 5;
            score= 0;

           

            //bizim araba konum
            owncar.Left = 160;
            owncar.Top = 300;

            //dier arabaların konum
            car1.Left = 30;
            car1.Top = 50;

            car2.Left = 320;
            car2.Top = 50;

            left = false;
            right = false;

            timer1.Start();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunuBaşlat();

            soundOn();
        }

        private void soundOn()
        {
                SoundPlayer soundPlayer = new SoundPlayer();
            string soundPath = Application.StartupPath + "//musıc.wav";
            soundPlayer.SoundLocation = soundPath;
            soundPlayer.Play();
        }

        private void road_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score++;//score 1 er artsın
            lbl_score.Text= score.ToString();//scoreu lbl score a yazdırma

            road.Top += roadspeed;
            if (road.Top > 357) { road.Top = -100; }//yol bittikçe baştan kaydır

            if (left) { owncar.Left -= owncarspeed; }
            if (right) { owncar.Left += owncarspeed; }

            if (owncar.Left < 1) { left = false; }
            else if (owncar.Left + owncar.Width > 512){ right = false; }

            car1.Top += othercarsspeed;
            car2.Top += othercarsspeed;

            if (car1.Top > panel1.Height)
            {
                car1Change();
                car1.Left = rnd.Next(20, 50);
                car1.Top = rnd.Next(40, 100) * -1;
            }
            if (car2.Top> panel1.Height)

              car2Change();
            car2.Left = rnd.Next(20, 50);
            car2.Top = rnd.Next(40, 100) * -1;


            if (owncar.Bounds.IntersectsWith(car1.Bounds) || owncar.Bounds.IntersectsWith(car2.Bounds))
            {
                gameOver();
            }

        }

        private void gameOver()
        {
            timer1.Stop();


            if (Convert.ToInt32(lbl_score.Text) > Convert.ToInt32(Settings1.Default.highScore.ToString()))
            {
                Settings1.Default.highScore =lbl_score.Text;
            }



            btn_start.Enabled = true;
            explasion.Visible= true;
            explasion.BringToFront();

            owncar.Controls.Add(explasion);
            explasion.Location = new Point(7, -5);
            explasion.BackColor= Color.Transparent;
            MessageBox.Show("Your new score : " + lbl_score.Text, "Game İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void car1Change()
        {
            int turn = rnd.Next(1, 7);

            switch (turn)
            {
                case 1:
                    car1.Image = Properties.Resources.araba4;
                    break;
                case 2:
                    car1.Image = Properties.Resources.araba3;
                    break;
                case 3:
                    car1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    car1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    car1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    car1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    car1.Image = Properties.Resources.araba7;
                    break;
                default:
                    break;
            }


        }
        private void car2Change()
        {
            int turn = rnd.Next(1, 7);

            switch (turn)
            {
                case 1:
                    car2.Image = Properties.Resources.araba5;
                    break;
                case 2:
                    car2.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    car2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    car2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    car2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    car2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    car2.Image = Properties.Resources.araba7;
                    break;
                default:
                    break;
            }


          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Left && owncar.Left>0) { left = true; }
            if(e.KeyCode== Keys.Right && owncar.Left+owncar.Width>0) {  right = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Right) { right = false; }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            oyunuBaşlat();
        }
    }
}

