namespace RadioButtonKullanımı
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
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.radio_kadın = new System.Windows.Forms.RadioButton();
            this.btn_goster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(41, 45);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(41, 13);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "Adınız :";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(119, 45);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(139, 20);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(41, 83);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(61, 13);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyadınız : ";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(119, 83);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(139, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(129, 132);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(53, 17);
            this.radio_erkek.TabIndex = 2;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // radio_kadın
            // 
            this.radio_kadın.AutoSize = true;
            this.radio_kadın.Location = new System.Drawing.Point(206, 132);
            this.radio_kadın.Name = "radio_kadın";
            this.radio_kadın.Size = new System.Drawing.Size(52, 17);
            this.radio_kadın.TabIndex = 3;
            this.radio_kadın.TabStop = true;
            this.radio_kadın.Text = "Kadın";
            this.radio_kadın.UseVisualStyleBackColor = true;
            // 
            // btn_goster
            // 
            this.btn_goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_goster.Location = new System.Drawing.Point(119, 187);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(139, 40);
            this.btn_goster.TabIndex = 4;
            this.btn_goster.Text = "Yazdır";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 273);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.radio_kadın);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_Ad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.RadioButton radio_kadın;
        private System.Windows.Forms.Button btn_goster;
    }
}

