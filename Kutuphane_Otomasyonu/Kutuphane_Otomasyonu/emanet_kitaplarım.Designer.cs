
namespace Kutuphane_Otomasyonu
{
    partial class emanet_kitaplarım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanet_kitaplarım));
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_yazar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_yayin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kitapadı = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_kitaptur = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_uyesil = new System.Windows.Forms.Button();
            this.btn_uyeguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(952, 483);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(118, 65);
            this.btn_geri.TabIndex = 49;
            this.btn_geri.Text = "İptal";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(952, 412);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(118, 65);
            this.btn_listele.TabIndex = 48;
            this.btn_listele.Text = "Tüm Kitaplar";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.combo_yazar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.combo_yayin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_barkod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kitapadı);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.combo_kitaptur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_uyesil);
            this.groupBox1.Controls.Add(this.btn_uyeguncelle);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 227);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Kitap İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(756, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 80;
            this.label10.Text = "*";
            // 
            // combo_yazar
            // 
            this.combo_yazar.FormattingEnabled = true;
            this.combo_yazar.Location = new System.Drawing.Point(392, 80);
            this.combo_yazar.Name = "combo_yazar";
            this.combo_yazar.Size = new System.Drawing.Size(159, 24);
            this.combo_yazar.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(578, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Toplam Raftaki Kitap:";
            // 
            // combo_yayin
            // 
            this.combo_yayin.FormattingEnabled = true;
            this.combo_yayin.Location = new System.Drawing.Point(136, 114);
            this.combo_yayin.Name = "combo_yayin";
            this.combo_yayin.Size = new System.Drawing.Size(159, 24);
            this.combo_yayin.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(168, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "*İşlem yapmak için listeden kitap seçin";
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(264, 21);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.ReadOnly = true;
            this.txt_barkod.Size = new System.Drawing.Size(166, 22);
            this.txt_barkod.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(188, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Kitap id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(42, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Kitap Adı:";
            // 
            // txt_kitapadı
            // 
            this.txt_kitapadı.Location = new System.Drawing.Point(136, 78);
            this.txt_kitapadı.Name = "txt_kitapadı";
            this.txt_kitapadı.Size = new System.Drawing.Size(159, 22);
            this.txt_kitapadı.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(322, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Yazar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(340, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Tür:";
            // 
            // combo_kitaptur
            // 
            this.combo_kitaptur.FormattingEnabled = true;
            this.combo_kitaptur.Location = new System.Drawing.Point(392, 114);
            this.combo_kitaptur.Name = "combo_kitaptur";
            this.combo_kitaptur.Size = new System.Drawing.Size(159, 24);
            this.combo_kitaptur.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(41, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "Yayın Evi:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(393, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 22);
            this.dateTimePicker2.TabIndex = 67;
            this.dateTimePicker2.Value = new System.DateTime(2023, 11, 27, 14, 32, 16, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 27, 14, 30, 44, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Teslim Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Alış Tarihi:";
            // 
            // btn_uyesil
            // 
            this.btn_uyesil.Location = new System.Drawing.Point(614, 119);
            this.btn_uyesil.Name = "btn_uyesil";
            this.btn_uyesil.Size = new System.Drawing.Size(133, 34);
            this.btn_uyesil.TabIndex = 39;
            this.btn_uyesil.Text = "Emanet Teslim ET";
            this.btn_uyesil.UseVisualStyleBackColor = true;
            this.btn_uyesil.Click += new System.EventHandler(this.btn_uyesil_Click);
            // 
            // btn_uyeguncelle
            // 
            this.btn_uyeguncelle.Location = new System.Drawing.Point(614, 78);
            this.btn_uyeguncelle.Name = "btn_uyeguncelle";
            this.btn_uyeguncelle.Size = new System.Drawing.Size(133, 34);
            this.btn_uyeguncelle.TabIndex = 38;
            this.btn_uyeguncelle.Text = "Emanet AL";
            this.btn_uyeguncelle.UseVisualStyleBackColor = true;
            this.btn_uyeguncelle.Click += new System.EventHandler(this.btn_uyeguncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 298);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(952, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 65);
            this.button1.TabIndex = 50;
            this.button1.Text = "Emanetlerim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 81;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emanet_kitaplarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "emanet_kitaplarım";
            this.Text = "Emanet Kitap İşlemleri";
            this.Load += new System.EventHandler(this.emanet_kitaplarım_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_uyesil;
        private System.Windows.Forms.Button btn_uyeguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_yazar;
        private System.Windows.Forms.ComboBox combo_yayin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapadı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_kitaptur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}