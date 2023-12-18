namespace kutuphaneOtomasyonu
{
    partial class Üye_sayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üye_sayfası));
            this.btn_üye_ara = new System.Windows.Forms.Button();
            this.btn_üye_çıkış = new System.Windows.Forms.Button();
            this.txt_üye_ara = new System.Windows.Forms.TextBox();
            this.btn_üye_yenile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayısı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yıl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_üye_ara
            // 
            this.btn_üye_ara.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_üye_ara.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_üye_ara.Location = new System.Drawing.Point(109, 22);
            this.btn_üye_ara.Name = "btn_üye_ara";
            this.btn_üye_ara.Size = new System.Drawing.Size(72, 21);
            this.btn_üye_ara.TabIndex = 0;
            this.btn_üye_ara.Text = "Ara";
            this.btn_üye_ara.UseVisualStyleBackColor = false;
            this.btn_üye_ara.Click += new System.EventHandler(this.btn_üye_ara_Click);
            // 
            // btn_üye_çıkış
            // 
            this.btn_üye_çıkış.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_üye_çıkış.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_üye_çıkış.Location = new System.Drawing.Point(278, 214);
            this.btn_üye_çıkış.Name = "btn_üye_çıkış";
            this.btn_üye_çıkış.Size = new System.Drawing.Size(273, 29);
            this.btn_üye_çıkış.TabIndex = 1;
            this.btn_üye_çıkış.Text = "Çıkış Yap";
            this.btn_üye_çıkış.UseVisualStyleBackColor = false;
            this.btn_üye_çıkış.Click += new System.EventHandler(this.btn_üye_çıkış_Click);
            // 
            // txt_üye_ara
            // 
            this.txt_üye_ara.Location = new System.Drawing.Point(187, 22);
            this.txt_üye_ara.Name = "txt_üye_ara";
            this.txt_üye_ara.Size = new System.Drawing.Size(182, 20);
            this.txt_üye_ara.TabIndex = 2;
            // 
            // btn_üye_yenile
            // 
            this.btn_üye_yenile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_üye_yenile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_üye_yenile.Location = new System.Drawing.Point(375, 22);
            this.btn_üye_yenile.Name = "btn_üye_yenile";
            this.btn_üye_yenile.Size = new System.Drawing.Size(73, 20);
            this.btn_üye_yenile.TabIndex = 0;
            this.btn_üye_yenile.Text = "Yenile";
            this.btn_üye_yenile.UseVisualStyleBackColor = false;
            this.btn_üye_yenile.Click += new System.EventHandler(this.btn_üye_yenile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.txt_üye_ara);
            this.groupBox1.Controls.Add(this.btn_üye_çıkış);
            this.groupBox1.Controls.Add(this.btn_üye_yenile);
            this.groupBox1.Controls.Add(this.btn_üye_ara);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(103, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 304);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üyelik İşlemleri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.sayfaSayısı,
            this.Yıl});
            this.dataGridView2.Location = new System.Drawing.Point(6, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(546, 149);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "İD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "İSİM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Yazar";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dil";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Yayınevi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tür";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Adet";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // sayfaSayısı
            // 
            this.sayfaSayısı.HeaderText = "Sayfa";
            this.sayfaSayısı.Name = "sayfaSayısı";
            this.sayfaSayısı.ReadOnly = true;
            this.sayfaSayısı.Width = 40;
            // 
            // Yıl
            // 
            this.Yıl.HeaderText = "Yıl";
            this.Yıl.Name = "Yıl";
            this.Yıl.ReadOnly = true;
            this.Yıl.Width = 40;
            // 
            // Üye_sayfası
            // 
            this.AcceptButton = this.btn_üye_ara;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_üye_çıkış;
            this.ClientSize = new System.Drawing.Size(756, 432);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Üye_sayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye_sayfası";
            this.Load += new System.EventHandler(this.Üye_sayfası_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_üye_ara;
        private System.Windows.Forms.Button btn_üye_çıkış;
        private System.Windows.Forms.TextBox txt_üye_ara;
        private System.Windows.Forms.Button btn_üye_yenile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayısı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yıl;
    }
}