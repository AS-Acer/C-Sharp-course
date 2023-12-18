namespace TabKontrol
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_anasayfa = new System.Windows.Forms.TabPage();
            this.tab_kllncIslem = new System.Windows.Forms.TabPage();
            this.tab_ayarlar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_anasayfa.SuspendLayout();
            this.tab_kllncIslem.SuspendLayout();
            this.tab_ayarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_anasayfa);
            this.tabControl1.Controls.Add(this.tab_kllncIslem);
            this.tabControl1.Controls.Add(this.tab_ayarlar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_anasayfa
            // 
            this.tab_anasayfa.Controls.Add(this.label3);
            this.tab_anasayfa.Location = new System.Drawing.Point(4, 22);
            this.tab_anasayfa.Name = "tab_anasayfa";
            this.tab_anasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_anasayfa.Size = new System.Drawing.Size(471, 267);
            this.tab_anasayfa.TabIndex = 0;
            this.tab_anasayfa.Text = "Anasayfa";
            this.tab_anasayfa.UseVisualStyleBackColor = true;
            // 
            // tab_kllncIslem
            // 
            this.tab_kllncIslem.Controls.Add(this.label2);
            this.tab_kllncIslem.Location = new System.Drawing.Point(4, 22);
            this.tab_kllncIslem.Name = "tab_kllncIslem";
            this.tab_kllncIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_kllncIslem.Size = new System.Drawing.Size(471, 267);
            this.tab_kllncIslem.TabIndex = 1;
            this.tab_kllncIslem.Text = "Kullanıcı İşlemleri";
            this.tab_kllncIslem.UseVisualStyleBackColor = true;
            // 
            // tab_ayarlar
            // 
            this.tab_ayarlar.Controls.Add(this.label1);
            this.tab_ayarlar.Location = new System.Drawing.Point(4, 22);
            this.tab_ayarlar.Name = "tab_ayarlar";
            this.tab_ayarlar.Size = new System.Drawing.Size(471, 267);
            this.tab_ayarlar.TabIndex = 2;
            this.tab_ayarlar.Text = "Ayarlar";
            this.tab_ayarlar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Burası ayarlar sayfasıdır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burası işlemler sayfasıdır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Burası anasayfadır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 293);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_anasayfa.ResumeLayout(false);
            this.tab_anasayfa.PerformLayout();
            this.tab_kllncIslem.ResumeLayout(false);
            this.tab_kllncIslem.PerformLayout();
            this.tab_ayarlar.ResumeLayout(false);
            this.tab_ayarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_anasayfa;
        private System.Windows.Forms.TabPage tab_kllncIslem;
        private System.Windows.Forms.TabPage tab_ayarlar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

