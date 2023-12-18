namespace MessageBoxKullanımı
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
            this.btn_cıkısyap = new System.Windows.Forms.Button();
            this.lbl_sonucYazısı = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cıkısyap
            // 
            this.btn_cıkısyap.Location = new System.Drawing.Point(98, 117);
            this.btn_cıkısyap.Name = "btn_cıkısyap";
            this.btn_cıkısyap.Size = new System.Drawing.Size(184, 40);
            this.btn_cıkısyap.TabIndex = 0;
            this.btn_cıkısyap.Text = "Çıkış yap";
            this.btn_cıkısyap.UseVisualStyleBackColor = true;
            this.btn_cıkısyap.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_sonucYazısı
            // 
            this.lbl_sonucYazısı.AutoSize = true;
            this.lbl_sonucYazısı.Location = new System.Drawing.Point(95, 64);
            this.lbl_sonucYazısı.Name = "lbl_sonucYazısı";
            this.lbl_sonucYazısı.Size = new System.Drawing.Size(47, 13);
            this.lbl_sonucYazısı.TabIndex = 1;
            this.lbl_sonucYazısı.Text = "Sonuç : ";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(200, 64);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(10, 13);
            this.lbl_sonuc.TabIndex = 1;
            this.lbl_sonuc.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 254);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_sonucYazısı);
            this.Controls.Add(this.btn_cıkısyap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cıkısyap;
        private System.Windows.Forms.Label lbl_sonucYazısı;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

