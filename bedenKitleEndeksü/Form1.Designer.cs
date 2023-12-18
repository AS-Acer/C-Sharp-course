namespace bedenKitleEndeksü
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablo = new System.Windows.Forms.RichTextBox();
            this.btn_gnclle = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.lbl_bdnendeks = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.lbl_tall = new System.Windows.Forms.Label();
            this.txt_boy = new System.Windows.Forms.TextBox();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.txt_kg = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonuç = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tablo);
            this.groupBox1.Controls.Add(this.btn_gnclle);
            this.groupBox1.Controls.Add(this.btn_remove);
            this.groupBox1.Controls.Add(this.btn_hesap);
            this.groupBox1.Controls.Add(this.lbl_bdnendeks);
            this.groupBox1.Controls.Add(this.lbl_sonuc);
            this.groupBox1.Controls.Add(this.lbl_tall);
            this.groupBox1.Controls.Add(this.txt_boy);
            this.groupBox1.Controls.Add(this.lbl_kg);
            this.groupBox1.Controls.Add(this.txt_kg);
            this.groupBox1.Controls.Add(this.lbl_surname);
            this.groupBox1.Controls.Add(this.txt_surname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beden Kitle Endeksi Hesaplama";
            // 
            // tablo
            // 
            this.tablo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tablo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tablo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tablo.Location = new System.Drawing.Point(156, 39);
            this.tablo.Name = "tablo";
            this.tablo.Size = new System.Drawing.Size(121, 78);
            this.tablo.TabIndex = 3;
            this.tablo.Text = "0-18 zayıf \n18-35 normal\n+35 obez";
            // 
            // btn_gnclle
            // 
            this.btn_gnclle.ForeColor = System.Drawing.Color.Black;
            this.btn_gnclle.Location = new System.Drawing.Point(192, 258);
            this.btn_gnclle.Name = "btn_gnclle";
            this.btn_gnclle.Size = new System.Drawing.Size(85, 29);
            this.btn_gnclle.TabIndex = 2;
            this.btn_gnclle.Text = "GÜNCELLE";
            this.btn_gnclle.UseVisualStyleBackColor = true;
            this.btn_gnclle.Click += new System.EventHandler(this.btn_gnclle_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(96, 258);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(85, 29);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "KALDIR";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_hesap
            // 
            this.btn_hesap.ForeColor = System.Drawing.Color.Black;
            this.btn_hesap.Location = new System.Drawing.Point(6, 258);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(84, 29);
            this.btn_hesap.TabIndex = 2;
            this.btn_hesap.Text = "HESAPLA";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // lbl_bdnendeks
            // 
            this.lbl_bdnendeks.AutoSize = true;
            this.lbl_bdnendeks.Location = new System.Drawing.Point(137, 180);
            this.lbl_bdnendeks.Name = "lbl_bdnendeks";
            this.lbl_bdnendeks.Size = new System.Drawing.Size(140, 13);
            this.lbl_bdnendeks.TabIndex = 1;
            this.lbl_bdnendeks.Text = "Beden kitle endeks puanınız";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(153, 199);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(10, 13);
            this.lbl_sonuc.TabIndex = 1;
            this.lbl_sonuc.Text = ".";
            // 
            // lbl_tall
            // 
            this.lbl_tall.AutoSize = true;
            this.lbl_tall.Location = new System.Drawing.Point(21, 180);
            this.lbl_tall.Name = "lbl_tall";
            this.lbl_tall.Size = new System.Drawing.Size(24, 13);
            this.lbl_tall.TabIndex = 1;
            this.lbl_tall.Text = "Tall";
            // 
            // txt_boy
            // 
            this.txt_boy.Location = new System.Drawing.Point(24, 196);
            this.txt_boy.Name = "txt_boy";
            this.txt_boy.Size = new System.Drawing.Size(100, 20);
            this.txt_boy.TabIndex = 0;
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(21, 141);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(41, 13);
            this.lbl_kg.TabIndex = 1;
            this.lbl_kg.Text = "Weight";
            // 
            // txt_kg
            // 
            this.txt_kg.Location = new System.Drawing.Point(24, 157);
            this.txt_kg.Name = "txt_kg";
            this.txt_kg.Size = new System.Drawing.Size(100, 20);
            this.txt_kg.TabIndex = 0;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(21, 102);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(49, 13);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(24, 118);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 20);
            this.txt_surname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(21, 23);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "İd";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(24, 79);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(24, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.weight,
            this.tall,
            this.sonuç});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(325, 15);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(389, 331);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.Width = 75;
            // 
            // surname
            // 
            this.surname.HeaderText = "surname";
            this.surname.Name = "surname";
            this.surname.Width = 75;
            // 
            // weight
            // 
            this.weight.HeaderText = "weight";
            this.weight.Name = "weight";
            this.weight.Width = 50;
            // 
            // tall
            // 
            this.tall.HeaderText = "tall";
            this.tall.Name = "tall";
            this.tall.Width = 40;
            // 
            // sonuç
            // 
            this.sonuç.HeaderText = "endeks ";
            this.sonuç.Name = "sonuç";
            this.sonuç.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.Label lbl_tall;
        private System.Windows.Forms.TextBox txt_boy;
        private System.Windows.Forms.Label lbl_kg;
        private System.Windows.Forms.TextBox txt_kg;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.RichTextBox tablo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_bdnendeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn tall;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuç;
        private System.Windows.Forms.Button btn_gnclle;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

