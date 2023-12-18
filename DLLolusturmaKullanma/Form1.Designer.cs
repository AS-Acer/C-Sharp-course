namespace DLLolusturmaKullanma
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
            this.lbl_sayı_1 = new System.Windows.Forms.Label();
            this.lbl_sayı_2 = new System.Windows.Forms.Label();
            this.txt_sayı_1 = new System.Windows.Forms.TextBox();
            this.txt_sayı_2 = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cıkar = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.lbl_sonucYazısı = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sayı_1
            // 
            this.lbl_sayı_1.AutoSize = true;
            this.lbl_sayı_1.Location = new System.Drawing.Point(56, 30);
            this.lbl_sayı_1.Name = "lbl_sayı_1";
            this.lbl_sayı_1.Size = new System.Drawing.Size(81, 13);
            this.lbl_sayı_1.TabIndex = 0;
            this.lbl_sayı_1.Text = "1.Sayıyı giriniz : ";
            // 
            // lbl_sayı_2
            // 
            this.lbl_sayı_2.AutoSize = true;
            this.lbl_sayı_2.Location = new System.Drawing.Point(56, 58);
            this.lbl_sayı_2.Name = "lbl_sayı_2";
            this.lbl_sayı_2.Size = new System.Drawing.Size(78, 13);
            this.lbl_sayı_2.TabIndex = 1;
            this.lbl_sayı_2.Text = "2.Sayıyı giriniz :";
            // 
            // txt_sayı_1
            // 
            this.txt_sayı_1.Location = new System.Drawing.Point(139, 22);
            this.txt_sayı_1.Name = "txt_sayı_1";
            this.txt_sayı_1.Size = new System.Drawing.Size(158, 20);
            this.txt_sayı_1.TabIndex = 2;
            // 
            // txt_sayı_2
            // 
            this.txt_sayı_2.Location = new System.Drawing.Point(139, 58);
            this.txt_sayı_2.Name = "txt_sayı_2";
            this.txt_sayı_2.Size = new System.Drawing.Size(158, 20);
            this.txt_sayı_2.TabIndex = 2;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(76, 136);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(56, 25);
            this.btn_topla.TabIndex = 3;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cıkar
            // 
            this.btn_cıkar.Location = new System.Drawing.Point(138, 136);
            this.btn_cıkar.Name = "btn_cıkar";
            this.btn_cıkar.Size = new System.Drawing.Size(56, 25);
            this.btn_cıkar.TabIndex = 3;
            this.btn_cıkar.Text = "-";
            this.btn_cıkar.UseVisualStyleBackColor = true;
            this.btn_cıkar.Click += new System.EventHandler(this.btn_cıkar_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(200, 136);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(56, 25);
            this.btn_carp.TabIndex = 3;
            this.btn_carp.Text = "x";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.Location = new System.Drawing.Point(262, 136);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(56, 25);
            this.btn_bolme.TabIndex = 3;
            this.btn_bolme.Text = "/";
            this.btn_bolme.UseVisualStyleBackColor = true;
            this.btn_bolme.Click += new System.EventHandler(this.btn_bolme_Click);
            // 
            // lbl_sonucYazısı
            // 
            this.lbl_sonucYazısı.AutoSize = true;
            this.lbl_sonucYazısı.Location = new System.Drawing.Point(92, 102);
            this.lbl_sonucYazısı.Name = "lbl_sonucYazısı";
            this.lbl_sonucYazısı.Size = new System.Drawing.Size(54, 13);
            this.lbl_sonucYazısı.TabIndex = 1;
            this.lbl_sonucYazısı.Text = "SONUÇ : ";
            this.lbl_sonucYazısı.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(152, 102);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(13, 13);
            this.lbl_sonuc.TabIndex = 1;
            this.lbl_sonuc.Text = "0";
            this.lbl_sonuc.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 211);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_cıkar);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_sayı_2);
            this.Controls.Add(this.txt_sayı_1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_sonucYazısı);
            this.Controls.Add(this.lbl_sayı_2);
            this.Controls.Add(this.lbl_sayı_1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sayı_1;
        private System.Windows.Forms.Label lbl_sayı_2;
        private System.Windows.Forms.TextBox txt_sayı_1;
        private System.Windows.Forms.TextBox txt_sayı_2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_cıkar;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Label lbl_sonucYazısı;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

