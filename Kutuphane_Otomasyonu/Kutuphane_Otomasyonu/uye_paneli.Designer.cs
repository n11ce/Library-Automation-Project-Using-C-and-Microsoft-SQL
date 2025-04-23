
namespace Kutuphane_Otomasyonu
{
    partial class uye_paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uye_paneli));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_uyebilgileri = new System.Windows.Forms.Button();
            this.btn_kitaplistele = new System.Windows.Forms.Button();
            this.btn_emanet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uyetxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kütüphane Otomasyonu";
            // 
            // btn_uyebilgileri
            // 
            this.btn_uyebilgileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_uyebilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uyebilgileri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_uyebilgileri.Location = new System.Drawing.Point(434, 61);
            this.btn_uyebilgileri.Name = "btn_uyebilgileri";
            this.btn_uyebilgileri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_uyebilgileri.Size = new System.Drawing.Size(245, 95);
            this.btn_uyebilgileri.TabIndex = 8;
            this.btn_uyebilgileri.Text = "Üye Bilgilerini Düzenle";
            this.btn_uyebilgileri.UseVisualStyleBackColor = true;
            this.btn_uyebilgileri.Click += new System.EventHandler(this.btn_uyebilgileri_Click);
            // 
            // btn_kitaplistele
            // 
            this.btn_kitaplistele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kitaplistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitaplistele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kitaplistele.Location = new System.Drawing.Point(434, 172);
            this.btn_kitaplistele.Name = "btn_kitaplistele";
            this.btn_kitaplistele.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_kitaplistele.Size = new System.Drawing.Size(245, 95);
            this.btn_kitaplistele.TabIndex = 16;
            this.btn_kitaplistele.Text = "Kitapları Listele";
            this.btn_kitaplistele.UseVisualStyleBackColor = true;
            this.btn_kitaplistele.Click += new System.EventHandler(this.btn_kitaplistele_Click);
            // 
            // btn_emanet
            // 
            this.btn_emanet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_emanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emanet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_emanet.Location = new System.Drawing.Point(434, 285);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_emanet.Size = new System.Drawing.Size(245, 95);
            this.btn_emanet.TabIndex = 17;
            this.btn_emanet.Text = "Emanet İşlemleri";
            this.btn_emanet.UseVisualStyleBackColor = true;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Üye id:";
            // 
            // uyetxt
            // 
            this.uyetxt.AutoSize = true;
            this.uyetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyetxt.Location = new System.Drawing.Point(766, 421);
            this.uyetxt.Name = "uyetxt";
            this.uyetxt.Size = new System.Drawing.Size(15, 20);
            this.uyetxt.TabIndex = 19;
            this.uyetxt.Text = "*";
            this.uyetxt.Click += new System.EventHandler(this.uyetxt_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(703, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // uye_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uyetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_emanet);
            this.Controls.Add(this.btn_kitaplistele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_uyebilgileri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uye_paneli";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Üye Paneli";
            this.Load += new System.EventHandler(this.uye_paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_uyebilgileri;
        private System.Windows.Forms.Button btn_kitaplistele;
        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyetxt;
        private System.Windows.Forms.Button button1;
    }
}