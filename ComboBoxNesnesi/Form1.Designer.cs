namespace ComboBoxNesnesi
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
            this.combo_gunler = new System.Windows.Forms.ComboBox();
            this.btn_gnSec = new System.Windows.Forms.Button();
            this.lbl_gunsec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_gunler
            // 
            this.combo_gunler.FormattingEnabled = true;
            this.combo_gunler.Items.AddRange(new object[] {
            "pazartesi ",
            "salı",
            "çarşamba",
            "perşembe",
            "cuma ",
            "cumartesi",
            "pazar"});
            this.combo_gunler.Location = new System.Drawing.Point(153, 25);
            this.combo_gunler.Name = "combo_gunler";
            this.combo_gunler.Size = new System.Drawing.Size(227, 21);
            this.combo_gunler.TabIndex = 0;
            this.combo_gunler.SelectedIndexChanged += new System.EventHandler(this.combo_gunler_SelectedIndexChanged);
            // 
            // btn_gnSec
            // 
            this.btn_gnSec.Location = new System.Drawing.Point(152, 67);
            this.btn_gnSec.Name = "btn_gnSec";
            this.btn_gnSec.Size = new System.Drawing.Size(227, 26);
            this.btn_gnSec.TabIndex = 1;
            this.btn_gnSec.Text = "Gün seçiniz : ";
            this.btn_gnSec.UseVisualStyleBackColor = true;
            this.btn_gnSec.Click += new System.EventHandler(this.combo_gunler_SelectedIndexChanged);
            this.btn_gnSec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_gnSec_MouseClick);
            // 
            // lbl_gunsec
            // 
            this.lbl_gunsec.AutoSize = true;
            this.lbl_gunsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunsec.Location = new System.Drawing.Point(12, 26);
            this.lbl_gunsec.Name = "lbl_gunsec";
            this.lbl_gunsec.Size = new System.Drawing.Size(104, 20);
            this.lbl_gunsec.TabIndex = 2;
            this.lbl_gunsec.Text = "Gün seçiniz : ";
            this.lbl_gunsec.Click += new System.EventHandler(this.lbl_gunsec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 332);
            this.Controls.Add(this.lbl_gunsec);
            this.Controls.Add(this.btn_gnSec);
            this.Controls.Add(this.combo_gunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_gunler;
        private System.Windows.Forms.Button btn_gnSec;
        private System.Windows.Forms.Label lbl_gunsec;
    }
}

