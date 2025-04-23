
namespace Kutuphane_Otomasyonu
{
    partial class uye_listele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uye_listele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_sehir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yetki = new System.Windows.Forms.CheckBox();
            this.uyeid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_uyesil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_uyeguncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kullanıciadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(81, 133);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(149, 22);
            this.txt_telefon.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "E-Posta:";
            // 
            // combo_sehir
            // 
            this.combo_sehir.FormattingEnabled = true;
            this.combo_sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.combo_sehir.Location = new System.Drawing.Point(81, 88);
            this.combo_sehir.Name = "combo_sehir";
            this.combo_sehir.Size = new System.Drawing.Size(149, 24);
            this.combo_sehir.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Şehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Telefon:";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(352, 92);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(149, 22);
            this.txt_adres.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Adres:";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(352, 131);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(149, 22);
            this.txt_mail.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Soyad:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(352, 51);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(149, 22);
            this.txt_soyad.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ad:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(81, 51);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(149, 22);
            this.txt_ad.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_kullanıciadi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.yetki);
            this.groupBox1.Controls.Add(this.uyeid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_uyesil);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_uyeguncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_telefon);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.combo_sehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_adres);
            this.groupBox1.Location = new System.Drawing.Point(12, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 276);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Düzenleme";
            // 
            // yetki
            // 
            this.yetki.AutoSize = true;
            this.yetki.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yetki.Location = new System.Drawing.Point(670, 131);
            this.yetki.Name = "yetki";
            this.yetki.Size = new System.Drawing.Size(73, 21);
            this.yetki.TabIndex = 48;
            this.yetki.Text = "Admin:";
            this.yetki.UseVisualStyleBackColor = true;
            // 
            // uyeid
            // 
            this.uyeid.AutoSize = true;
            this.uyeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeid.Location = new System.Drawing.Point(297, 18);
            this.uyeid.Name = "uyeid";
            this.uyeid.Size = new System.Drawing.Size(15, 20);
            this.uyeid.TabIndex = 47;
            this.uyeid.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Seçili Üye ID:";
            // 
            // btn_uyesil
            // 
            this.btn_uyesil.Location = new System.Drawing.Point(398, 199);
            this.btn_uyesil.Name = "btn_uyesil";
            this.btn_uyesil.Size = new System.Drawing.Size(133, 34);
            this.btn_uyesil.TabIndex = 39;
            this.btn_uyesil.Text = "Sil";
            this.btn_uyesil.UseVisualStyleBackColor = true;
            this.btn_uyesil.Click += new System.EventHandler(this.btn_uyesil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "*İşlem yapmak için listeden üye seçin";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_uyeguncelle
            // 
            this.btn_uyeguncelle.Location = new System.Drawing.Point(259, 199);
            this.btn_uyeguncelle.Name = "btn_uyeguncelle";
            this.btn_uyeguncelle.Size = new System.Drawing.Size(133, 34);
            this.btn_uyeguncelle.TabIndex = 38;
            this.btn_uyeguncelle.Text = "Güncelle";
            this.btn_uyeguncelle.UseVisualStyleBackColor = true;
            this.btn_uyeguncelle.Click += new System.EventHandler(this.btn_uyeguncelle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(928, 576);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(118, 65);
            this.btn_listele.TabIndex = 40;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(1052, 576);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(118, 65);
            this.btn_geri.TabIndex = 45;
            this.btn_geri.Text = "İptal";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(530, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Kullanıcı Adı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(587, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Şifre:";
            // 
            // txt_kullanıciadi
            // 
            this.txt_kullanıciadi.Location = new System.Drawing.Point(642, 49);
            this.txt_kullanıciadi.Name = "txt_kullanıciadi";
            this.txt_kullanıciadi.Size = new System.Drawing.Size(149, 22);
            this.txt_kullanıciadi.TabIndex = 51;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(642, 88);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(149, 22);
            this.txt_sifre.TabIndex = 52;
            // 
            // uye_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uye_listele";
            this.Text = "Üyeleri Düzenle";
            this.Load += new System.EventHandler(this.uye_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_sehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_uyesil;
        private System.Windows.Forms.Button btn_uyeguncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label uyeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox yetki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullanıciadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}