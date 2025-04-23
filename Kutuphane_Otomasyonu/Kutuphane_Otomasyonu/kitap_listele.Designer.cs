
namespace Kutuphane_Otomasyonu
{
    partial class kitap_listele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_listele));
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kitapsil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_kitapguncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kitapadı = new System.Windows.Forms.TextBox();
            this.txt_kitapsayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kitapyazar = new System.Windows.Forms.TextBox();
            this.combo_kitaptur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_kitapyayınevi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(878, 578);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(118, 65);
            this.btn_listele.TabIndex = 43;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_kitapsil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_barkod);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_kitapguncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kitapadı);
            this.groupBox1.Controls.Add(this.txt_kitapsayfa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_kitapyazar);
            this.groupBox1.Controls.Add(this.combo_kitaptur);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_kitapyayınevi);
            this.groupBox1.Location = new System.Drawing.Point(12, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 256);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Düzenleme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Durum:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rafta",
            "Rafta Değil"});
            this.comboBox1.Location = new System.Drawing.Point(430, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Sayfa Sayısı:";
            // 
            // btn_kitapsil
            // 
            this.btn_kitapsil.Location = new System.Drawing.Point(361, 171);
            this.btn_kitapsil.Name = "btn_kitapsil";
            this.btn_kitapsil.Size = new System.Drawing.Size(159, 34);
            this.btn_kitapsil.TabIndex = 39;
            this.btn_kitapsil.Text = "Sil";
            this.btn_kitapsil.UseVisualStyleBackColor = true;
            this.btn_kitapsil.Click += new System.EventHandler(this.btn_kitapsil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Kitap ID:";
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(250, 18);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.ReadOnly = true;
            this.txt_barkod.Size = new System.Drawing.Size(185, 22);
            this.txt_barkod.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "*İşlem yapmak için listeden kitap seçin";
            // 
            // btn_kitapguncelle
            // 
            this.btn_kitapguncelle.Location = new System.Drawing.Point(170, 171);
            this.btn_kitapguncelle.Name = "btn_kitapguncelle";
            this.btn_kitapguncelle.Size = new System.Drawing.Size(159, 34);
            this.btn_kitapguncelle.TabIndex = 38;
            this.btn_kitapguncelle.Text = "Güncelle";
            this.btn_kitapguncelle.UseVisualStyleBackColor = true;
            this.btn_kitapguncelle.Click += new System.EventHandler(this.btn_kitapguncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kitap Adı:";
            // 
            // txt_kitapadı
            // 
            this.txt_kitapadı.Location = new System.Drawing.Point(430, 62);
            this.txt_kitapadı.Name = "txt_kitapadı";
            this.txt_kitapadı.Size = new System.Drawing.Size(217, 22);
            this.txt_kitapadı.TabIndex = 45;
            // 
            // txt_kitapsayfa
            // 
            this.txt_kitapsayfa.Location = new System.Drawing.Point(119, 133);
            this.txt_kitapsayfa.Name = "txt_kitapsayfa";
            this.txt_kitapsayfa.Size = new System.Drawing.Size(212, 22);
            this.txt_kitapsayfa.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tür:";
            // 
            // txt_kitapyazar
            // 
            this.txt_kitapyazar.Location = new System.Drawing.Point(119, 62);
            this.txt_kitapyazar.Name = "txt_kitapyazar";
            this.txt_kitapyazar.Size = new System.Drawing.Size(212, 22);
            this.txt_kitapyazar.TabIndex = 54;
            // 
            // combo_kitaptur
            // 
            this.combo_kitaptur.FormattingEnabled = true;
            this.combo_kitaptur.Items.AddRange(new object[] {
            "Anı",
            "Anlatı",
            "Araştırma-İnceleme",
            "Bilim",
            "Biyografi",
            "Çizgi Roman",
            "Deneme",
            "Edebiyat",
            "Eğitim",
            "Felsefe",
            "Gençlik",
            "Gezi",
            "Hikâye",
            "Hobi",
            "İnceleme",
            "İş Ekonomi – Hukuk",
            "Kişisel Gelişim",
            "Konuşmalar",
            "Masal",
            "Mektup",
            "Mizah",
            "Öykü",
            "Polisiye",
            "Psikoloji",
            "Resimli Öykü",
            "Roman",
            "Sağlık",
            "Sanat – Tasarım",
            "Sanat- Müzik",
            "Sinema Tarihi",
            "Söyleşi",
            "Şiir",
            "Tarih",
            "Yemek Kitapları"});
            this.combo_kitaptur.Location = new System.Drawing.Point(430, 98);
            this.combo_kitaptur.Name = "combo_kitaptur";
            this.combo_kitaptur.Size = new System.Drawing.Size(217, 24);
            this.combo_kitaptur.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Yayın Evi:";
            // 
            // txt_kitapyayınevi
            // 
            this.txt_kitapyayınevi.Location = new System.Drawing.Point(119, 100);
            this.txt_kitapyayınevi.Name = "txt_kitapyayınevi";
            this.txt_kitapyayınevi.Size = new System.Drawing.Size(212, 22);
            this.txt_kitapyayınevi.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 378);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(1002, 578);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(118, 65);
            this.btn_geri.TabIndex = 44;
            this.btn_geri.Text = "İptal";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // kitap_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kitap_listele";
            this.Text = "Kitap Yönetim";
            this.Load += new System.EventHandler(this.kitap_listele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kitapsil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_kitapguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kitapyazar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_kitaptur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_kitapyayınevi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kitapsayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kitapadı;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}