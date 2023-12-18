namespace CheckBoxKullanımı
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
            this.checkBox_cay = new System.Windows.Forms.CheckBox();
            this.checkBox_kahve = new System.Windows.Forms.CheckBox();
            this.CheckBox_kola = new System.Windows.Forms.CheckBox();
            this.checkBox_brger = new System.Windows.Forms.CheckBox();
            this.checkBox_pizza = new System.Windows.Forms.CheckBox();
            this.lbl_tutarYazı = new System.Windows.Forms.Label();
            this.lbl_tutarDeger = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_cay
            // 
            this.checkBox_cay.AutoSize = true;
            this.checkBox_cay.Location = new System.Drawing.Point(35, 24);
            this.checkBox_cay.Name = "checkBox_cay";
            this.checkBox_cay.Size = new System.Drawing.Size(69, 17);
            this.checkBox_cay.TabIndex = 0;
            this.checkBox_cay.Text = "Çay 2 TL";
            this.checkBox_cay.UseVisualStyleBackColor = true;
            // 
            // checkBox_kahve
            // 
            this.checkBox_kahve.AutoSize = true;
            this.checkBox_kahve.Location = new System.Drawing.Point(35, 47);
            this.checkBox_kahve.Name = "checkBox_kahve";
            this.checkBox_kahve.Size = new System.Drawing.Size(82, 17);
            this.checkBox_kahve.TabIndex = 1;
            this.checkBox_kahve.Text = "Kahve 5 TL";
            this.checkBox_kahve.UseVisualStyleBackColor = true;
            // 
            // CheckBox_kola
            // 
            this.CheckBox_kola.AutoSize = true;
            this.CheckBox_kola.Location = new System.Drawing.Point(35, 70);
            this.CheckBox_kola.Name = "CheckBox_kola";
            this.CheckBox_kola.Size = new System.Drawing.Size(72, 17);
            this.CheckBox_kola.TabIndex = 1;
            this.CheckBox_kola.Text = "Kola 4 TL";
            this.CheckBox_kola.UseVisualStyleBackColor = true;
            // 
            // checkBox_brger
            // 
            this.checkBox_brger.AutoSize = true;
            this.checkBox_brger.Location = new System.Drawing.Point(35, 93);
            this.checkBox_brger.Name = "checkBox_brger";
            this.checkBox_brger.Size = new System.Drawing.Size(109, 17);
            this.checkBox_brger.TabIndex = 1;
            this.checkBox_brger.Text = "Hamburger 10 TL";
            this.checkBox_brger.UseVisualStyleBackColor = true;
            // 
            // checkBox_pizza
            // 
            this.checkBox_pizza.AutoSize = true;
            this.checkBox_pizza.Location = new System.Drawing.Point(35, 116);
            this.checkBox_pizza.Name = "checkBox_pizza";
            this.checkBox_pizza.Size = new System.Drawing.Size(82, 17);
            this.checkBox_pizza.TabIndex = 1;
            this.checkBox_pizza.Text = "Pizza 24 TL";
            this.checkBox_pizza.UseVisualStyleBackColor = true;
            // 
            // lbl_tutarYazı
            // 
            this.lbl_tutarYazı.AutoSize = true;
            this.lbl_tutarYazı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutarYazı.Location = new System.Drawing.Point(219, 51);
            this.lbl_tutarYazı.Name = "lbl_tutarYazı";
            this.lbl_tutarYazı.Size = new System.Drawing.Size(123, 18);
            this.lbl_tutarYazı.TabIndex = 2;
            this.lbl_tutarYazı.Text = "Toplam Tutar : ";
            // 
            // lbl_tutarDeger
            // 
            this.lbl_tutarDeger.AutoSize = true;
            this.lbl_tutarDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutarDeger.Location = new System.Drawing.Point(348, 51);
            this.lbl_tutarDeger.Name = "lbl_tutarDeger";
            this.lbl_tutarDeger.Size = new System.Drawing.Size(41, 18);
            this.lbl_tutarDeger.TabIndex = 2;
            this.lbl_tutarDeger.Text = "0 TL";
            this.lbl_tutarDeger.Click += new System.EventHandler(this.lbl_tutarDeger_Click);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(42, 177);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(222, 47);
            this.btn_hesapla.TabIndex = 3;
            this.btn_hesapla.Text = "Hesapla ";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 303);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.lbl_tutarDeger);
            this.Controls.Add(this.lbl_tutarYazı);
            this.Controls.Add(this.checkBox_pizza);
            this.Controls.Add(this.checkBox_brger);
            this.Controls.Add(this.CheckBox_kola);
            this.Controls.Add(this.checkBox_kahve);
            this.Controls.Add(this.checkBox_cay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_cay;
        private System.Windows.Forms.CheckBox checkBox_kahve;
        private System.Windows.Forms.CheckBox CheckBox_kola;
        private System.Windows.Forms.CheckBox checkBox_brger;
        private System.Windows.Forms.CheckBox checkBox_pizza;
        private System.Windows.Forms.Label lbl_tutarYazı;
        private System.Windows.Forms.Label lbl_tutarDeger;
        private System.Windows.Forms.Button btn_hesapla;
    }
}

