namespace ListBoxKullanımı
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
            this.lbl_degergir = new System.Windows.Forms.Label();
            this.txt_degerGir = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_countBul = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_degergir
            // 
            this.lbl_degergir.AutoSize = true;
            this.lbl_degergir.Location = new System.Drawing.Point(47, 46);
            this.lbl_degergir.Name = "lbl_degergir";
            this.lbl_degergir.Size = new System.Drawing.Size(163, 13);
            this.lbl_degergir.TabIndex = 0;
            this.lbl_degergir.Text = "Eklemek istediğiniz değeri giriniz :";
            // 
            // txt_degerGir
            // 
            this.txt_degerGir.Location = new System.Drawing.Point(261, 46);
            this.txt_degerGir.Name = "txt_degerGir";
            this.txt_degerGir.Size = new System.Drawing.Size(193, 20);
            this.txt_degerGir.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(261, 99);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(193, 33);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(261, 138);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(193, 33);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_countBul
            // 
            this.btn_countBul.Location = new System.Drawing.Point(261, 177);
            this.btn_countBul.Name = "btn_countBul";
            this.btn_countBul.Size = new System.Drawing.Size(193, 33);
            this.btn_countBul.TabIndex = 2;
            this.btn_countBul.Text = "Count Bul";
            this.btn_countBul.UseVisualStyleBackColor = true;
            this.btn_countBul.Click += new System.EventHandler(this.btn_countBul_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(261, 216);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(193, 33);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 173);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 290);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_countBul);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_degerGir);
            this.Controls.Add(this.lbl_degergir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_degergir;
        private System.Windows.Forms.TextBox txt_degerGir;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_countBul;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ListBox listBox1;
    }
}

