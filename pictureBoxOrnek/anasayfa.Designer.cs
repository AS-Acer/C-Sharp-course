namespace pictureBoxOrnek
{
    partial class anasayfa
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
            this.Lbl_hg = new System.Windows.Forms.Label();
            this.lbl_ana_deger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_hg
            // 
            this.Lbl_hg.AutoSize = true;
            this.Lbl_hg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_hg.Location = new System.Drawing.Point(47, 61);
            this.Lbl_hg.Name = "Lbl_hg";
            this.Lbl_hg.Size = new System.Drawing.Size(131, 20);
            this.Lbl_hg.TabIndex = 0;
            this.Lbl_hg.Text = "HOŞGELDİNİZ";
            // 
            // lbl_ana_deger
            // 
            this.lbl_ana_deger.AutoSize = true;
            this.lbl_ana_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ana_deger.Location = new System.Drawing.Point(209, 66);
            this.lbl_ana_deger.Name = "lbl_ana_deger";
            this.lbl_ana_deger.Size = new System.Drawing.Size(13, 20);
            this.lbl_ana_deger.TabIndex = 0;
            this.lbl_ana_deger.Text = ".";
            this.lbl_ana_deger.Click += new System.EventHandler(this.lbl_ana_deger_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 283);
            this.Controls.Add(this.lbl_ana_deger);
            this.Controls.Add(this.Lbl_hg);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_hg;
        public System.Windows.Forms.Label lbl_ana_deger;
    }
}