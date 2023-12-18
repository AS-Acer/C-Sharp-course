namespace car_racing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.explasion = new System.Windows.Forms.PictureBox();
            this.owncar = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.road = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_highScore = new System.Windows.Forms.Label();
            this.lbl_HighScoretext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explasion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.owncar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.explasion);
            this.panel1.Controls.Add(this.owncar);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.road);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // explasion
            // 
            this.explasion.Image = global::car_racing.Properties.Resources.explosion;
            this.explasion.Location = new System.Drawing.Point(292, 305);
            this.explasion.Name = "explasion";
            this.explasion.Size = new System.Drawing.Size(66, 71);
            this.explasion.TabIndex = 2;
            this.explasion.TabStop = false;
            // 
            // owncar
            // 
            this.owncar.Image = global::car_racing.Properties.Resources.araba9;
            this.owncar.Location = new System.Drawing.Point(218, 369);
            this.owncar.Name = "owncar";
            this.owncar.Size = new System.Drawing.Size(69, 134);
            this.owncar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.owncar.TabIndex = 1;
            this.owncar.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::car_racing.Properties.Resources.araba7;
            this.car2.Location = new System.Drawing.Point(349, 130);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(69, 134);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 1;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::car_racing.Properties.Resources.araba4;
            this.car1.Location = new System.Drawing.Point(98, 130);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(69, 134);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // road
            // 
            this.road.Image = global::car_racing.Properties.Resources.yol;
            this.road.Location = new System.Drawing.Point(-6, -252);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(513, 775);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            this.road.Click += new System.EventHandler(this.road_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(400, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(498, 573);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(21, 22);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "0";
            this.lbl_score.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_start.Location = new System.Drawing.Point(12, 622);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(518, 51);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_highScore
            // 
            this.lbl_highScore.AutoSize = true;
            this.lbl_highScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_highScore.Location = new System.Drawing.Point(12, 573);
            this.lbl_highScore.Name = "lbl_highScore";
            this.lbl_highScore.Size = new System.Drawing.Size(124, 22);
            this.lbl_highScore.TabIndex = 1;
            this.lbl_highScore.Text = "High Score :";
            this.lbl_highScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_HighScoretext
            // 
            this.lbl_HighScoretext.AutoSize = true;
            this.lbl_HighScoretext.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HighScoretext.Location = new System.Drawing.Point(142, 573);
            this.lbl_HighScoretext.Name = "lbl_HighScoretext";
            this.lbl_HighScoretext.Size = new System.Drawing.Size(21, 22);
            this.lbl_HighScoretext.TabIndex = 1;
            this.lbl_HighScoretext.Text = "0";
            this.lbl_HighScoretext.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 685);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_HighScoretext);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_highScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explasion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.owncar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox owncar;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox explasion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_highScore;
        private System.Windows.Forms.Label lbl_HighScoretext;
    }
}

