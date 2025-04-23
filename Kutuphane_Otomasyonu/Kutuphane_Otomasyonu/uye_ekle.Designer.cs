
namespace Kutuphane_Otomasyonu
{
    partial class uye_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uye_ekle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_uyeekle1 = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kaditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.txt_sifre2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "KAYIT OL";
            // 
            // btn_uyeekle1
            // 
            this.btn_uyeekle1.Location = new System.Drawing.Point(143, 308);
            this.btn_uyeekle1.Name = "btn_uyeekle1";
            this.btn_uyeekle1.Size = new System.Drawing.Size(131, 32);
            this.btn_uyeekle1.TabIndex = 25;
            this.btn_uyeekle1.Text = "Kayıt Ol";
            this.btn_uyeekle1.UseVisualStyleBackColor = true;
            this.btn_uyeekle1.Click += new System.EventHandler(this.btn_uyeekle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(143, 346);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(131, 32);
            this.btn_geri.TabIndex = 46;
            this.btn_geri.Text = "Çık";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Kullanıcı Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Şifre:";
            // 
            // kaditxt
            // 
            this.kaditxt.Location = new System.Drawing.Point(131, 204);
            this.kaditxt.Name = "kaditxt";
            this.kaditxt.Size = new System.Drawing.Size(185, 22);
            this.kaditxt.TabIndex = 49;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(131, 232);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(185, 22);
            this.sifretxt.TabIndex = 50;
            // 
            // txt_sifre2
            // 
            this.txt_sifre2.Location = new System.Drawing.Point(131, 262);
            this.txt_sifre2.Name = "txt_sifre2";
            this.txt_sifre2.PasswordChar = '*';
            this.txt_sifre2.Size = new System.Drawing.Size(185, 22);
            this.txt_sifre2.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Şifre Tekrarı:";
            // 
            // uye_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 503);
            this.Controls.Add(this.txt_sifre2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kaditxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_uyeekle1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uye_ekle";
            this.Text = "uye_ekle";
            this.Load += new System.EventHandler(this.uye_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_uyeekle1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kaditxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.TextBox txt_sifre2;
        private System.Windows.Forms.Label label2;
    }
}