using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class yonetim_paneli : Form
    {
        public yonetim_paneli()
        {
            InitializeComponent();
        }

        private void btn_uyeekle_Click(object sender, EventArgs e)
        {
            uye_ekle uyeekle = new uye_ekle();
            uyeekle.Show();
            this.Hide();
        }

        private void btn_üyelistele_Click(object sender, EventArgs e)
        {
            uye_listele uyelistele = new uye_listele();
            uyelistele.Show();
            this.Hide();
        }

        private void btn_emanetlistele_Click(object sender, EventArgs e)
        {
            emanet_kitap_listele emanet_Kitap_Listele = new emanet_kitap_listele();
            emanet_Kitap_Listele.Show();
            this.Hide();
        }

        private void btn_emanetekle_Click(object sender, EventArgs e)
        {
            emanet_kitaplarım emanet_Kitaplarım = new emanet_kitaplarım();
            emanet_Kitaplarım.Show();
            this.Hide();
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            kitap_ekle kitap_Ekle = new kitap_ekle();
            kitap_Ekle.Show();
            this.Hide();

        }

        private void btn_kitaplistele_Click(object sender, EventArgs e)
        {
            kitap_listele kitap_Listele = new kitap_listele();
            kitap_Listele.Show();
            this.Hide();
        }

        private void yonetim_paneli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_Ekran ana_Ekran = new Ana_Ekran();
            ana_Ekran.Show();
            this.Close();
        }
    }
}
