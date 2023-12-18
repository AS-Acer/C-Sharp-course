namespace windowsformgiriş
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ortalamaHesapla = new System.Windows.Forms.Button();
            this.txt_birinciNot = new System.Windows.Forms.TextBox();
            this.lbl_ikinciNot = new System.Windows.Forms.Label();
            this.txt_ikinciNot = new System.Windows.Forms.TextBox();
            this.lbl_ortalamaSonuc = new System.Windows.Forms.Label();
            this.lbl_ortalamaIısaret = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Notu giriniz  :";
            // 
            // btn_ortalamaHesapla
            // 
            this.btn_ortalamaHesapla.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ortalamaHesapla.Location = new System.Drawing.Point(36, 156);
            this.btn_ortalamaHesapla.Name = "btn_ortalamaHesapla";
            this.btn_ortalamaHesapla.Size = new System.Drawing.Size(130, 22);
            this.btn_ortalamaHesapla.TabIndex = 1;
            this.btn_ortalamaHesapla.Text = "Hesapla";
            this.btn_ortalamaHesapla.UseVisualStyleBackColor = false;
            this.btn_ortalamaHesapla.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_birinciNot
            // 
            this.txt_birinciNot.BackColor = System.Drawing.Color.DimGray;
            this.txt_birinciNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_birinciNot.Location = new System.Drawing.Point(140, 70);
            this.txt_birinciNot.Multiline = true;
            this.txt_birinciNot.Name = "txt_birinciNot";
            this.txt_birinciNot.Size = new System.Drawing.Size(145, 19);
            this.txt_birinciNot.TabIndex = 2;
            this.txt_birinciNot.TextChanged += new System.EventHandler(this.txt_birinciNot_TextChanged);
            // 
            // lbl_ikinciNot
            // 
            this.lbl_ikinciNot.AutoSize = true;
            this.lbl_ikinciNot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikinciNot.Location = new System.Drawing.Point(32, 116);
            this.lbl_ikinciNot.Name = "lbl_ikinciNot";
            this.lbl_ikinciNot.Size = new System.Drawing.Size(101, 19);
            this.lbl_ikinciNot.TabIndex = 0;
            this.lbl_ikinciNot.Text = "2.Notu giriniz  :";
            // 
            // txt_ikinciNot
            // 
            this.txt_ikinciNot.BackColor = System.Drawing.Color.DimGray;
            this.txt_ikinciNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ikinciNot.Location = new System.Drawing.Point(140, 116);
            this.txt_ikinciNot.Multiline = true;
            this.txt_ikinciNot.Name = "txt_ikinciNot";
            this.txt_ikinciNot.Size = new System.Drawing.Size(145, 19);
            this.txt_ikinciNot.TabIndex = 2;
            // 
            // lbl_ortalamaSonuc
            // 
            this.lbl_ortalamaSonuc.AutoSize = true;
            this.lbl_ortalamaSonuc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ortalamaSonuc.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_ortalamaSonuc.Location = new System.Drawing.Point(254, 156);
            this.lbl_ortalamaSonuc.Name = "lbl_ortalamaSonuc";
            this.lbl_ortalamaSonuc.Size = new System.Drawing.Size(22, 25);
            this.lbl_ortalamaSonuc.TabIndex = 0;
            this.lbl_ortalamaSonuc.Text = "0";
            this.lbl_ortalamaSonuc.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_ortalamaIısaret
            // 
            this.lbl_ortalamaIısaret.AutoSize = true;
            this.lbl_ortalamaIısaret.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ortalamaIısaret.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_ortalamaIısaret.Location = new System.Drawing.Point(172, 159);
            this.lbl_ortalamaIısaret.Name = "lbl_ortalamaIısaret";
            this.lbl_ortalamaIısaret.Size = new System.Drawing.Size(76, 19);
            this.lbl_ortalamaIısaret.TabIndex = 0;
            this.lbl_ortalamaIısaret.Text = "Ortalama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOT HESAPLAMA UYGULAMASINA HOŞGELDİNİZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.txt_ikinciNot);
            this.Controls.Add(this.txt_birinciNot);
            this.Controls.Add(this.lbl_ortalamaSonuc);
            this.Controls.Add(this.lbl_ikinciNot);
            this.Controls.Add(this.btn_ortalamaHesapla);
            this.Controls.Add(this.lbl_ortalamaIısaret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ortalamaHesapla;
        private System.Windows.Forms.TextBox txt_birinciNot;
        private System.Windows.Forms.Label lbl_ikinciNot;
        private System.Windows.Forms.TextBox txt_ikinciNot;
        private System.Windows.Forms.Label lbl_ortalamaSonuc;
        private System.Windows.Forms.Label lbl_ortalamaIısaret;
        private System.Windows.Forms.Label label2;
    }
}

