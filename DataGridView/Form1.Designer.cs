namespace DataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İŞLEMLER = new System.Windows.Forms.GroupBox();
            this.btn_gnclle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_goster = new System.Windows.Forms.Button();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.İŞLEMLER.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.soyisim});
            this.dataGridView1.Location = new System.Drawing.Point(294, 13);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 281);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "İD";
            this.id.Name = "id";
            // 
            // isim
            // 
            this.isim.HeaderText = "İSİM";
            this.isim.Name = "isim";
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "SOYİSİM";
            this.soyisim.Name = "soyisim";
            // 
            // İŞLEMLER
            // 
            this.İŞLEMLER.Controls.Add(this.btn_gnclle);
            this.İŞLEMLER.Controls.Add(this.btn_sil);
            this.İŞLEMLER.Controls.Add(this.btn_ekle);
            this.İŞLEMLER.Controls.Add(this.btn_goster);
            this.İŞLEMLER.Controls.Add(this.txt_isim);
            this.İŞLEMLER.Controls.Add(this.lbl_isim);
            this.İŞLEMLER.Controls.Add(this.txt_id);
            this.İŞLEMLER.Controls.Add(this.lbl_id);
            this.İŞLEMLER.Controls.Add(this.txt_soyisim);
            this.İŞLEMLER.Controls.Add(this.lbl_soyisim);
            this.İŞLEMLER.Location = new System.Drawing.Point(13, 13);
            this.İŞLEMLER.Name = "İŞLEMLER";
            this.İŞLEMLER.Size = new System.Drawing.Size(275, 281);
            this.İŞLEMLER.TabIndex = 4;
            this.İŞLEMLER.TabStop = false;
            this.İŞLEMLER.Text = "groupBox1";
            // 
            // btn_gnclle
            // 
            this.btn_gnclle.Location = new System.Drawing.Point(34, 221);
            this.btn_gnclle.Name = "btn_gnclle";
            this.btn_gnclle.Size = new System.Drawing.Size(212, 24);
            this.btn_gnclle.TabIndex = 9;
            this.btn_gnclle.Text = "Güncelle";
            this.btn_gnclle.UseVisualStyleBackColor = true;
            this.btn_gnclle.Click += new System.EventHandler(this.btn_gnclle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(34, 191);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(212, 24);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(34, 161);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(212, 24);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(33, 131);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(212, 24);
            this.btn_goster.TabIndex = 12;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(97, 62);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(148, 20);
            this.txt_isim.TabIndex = 6;
            this.txt_isim.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(28, 69);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(37, 13);
            this.lbl_isim.TabIndex = 3;
            this.lbl_isim.Text = "İsim :  ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(98, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(148, 20);
            this.txt_id.TabIndex = 7;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(31, 43);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "İd :";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(97, 88);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(148, 20);
            this.txt_soyisim.TabIndex = 8;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(28, 95);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(48, 13);
            this.lbl_soyisim.TabIndex = 5;
            this.lbl_soyisim.Text = "Soyisim :";
            this.lbl_soyisim.Click += new System.EventHandler(this.lbl_soyisim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 323);
            this.Controls.Add(this.İŞLEMLER);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.İŞLEMLER.ResumeLayout(false);
            this.İŞLEMLER.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.GroupBox İŞLEMLER;
        private System.Windows.Forms.Button btn_gnclle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_soyisim;
    }
}

