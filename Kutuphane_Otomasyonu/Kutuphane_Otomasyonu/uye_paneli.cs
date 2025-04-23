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
    public partial class uye_paneli : Form
    {
        public static int uyeid = 0;
        public uye_paneli()
        {
            InitializeComponent();
        }

        private void btn_uyebilgileri_Click(object sender, EventArgs e)
        {
            uye_bilgileri uye_Bilgileri = new uye_bilgileri();
            uye_Bilgileri.Show();
            this.Close();
        }

        private void uye_paneli_Load(object sender, EventArgs e)
        {
            if (uye_ekle.uyeid == 0)
            {
                uyeid = Ana_Ekran.uyeid;
            }
            if (Ana_Ekran.uyeid == 0)
            {
                uyeid = uye_ekle.uyeid;
            }
            uyetxt.Text = uyeid.ToString();
        }

        private void uyetxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeid = 0;
            Ana_Ekran ana_Ekran = new Ana_Ekran();
            ana_Ekran.Show();
            this.Close();
        }

        private void btn_kitaplistele_Click(object sender, EventArgs e)
        {
            kitap_listele_uye kitap_Listele_Uye = new kitap_listele_uye();
            kitap_Listele_Uye.Show();
            this.Hide();
        }

        private void btn_emanet_Click(object sender, EventArgs e)
        {
            emanet_kitaplarım emanet_Kitaplarım = new emanet_kitaplarım();
            emanet_Kitaplarım.Show();
            this.Hide();
        }
    }
}
