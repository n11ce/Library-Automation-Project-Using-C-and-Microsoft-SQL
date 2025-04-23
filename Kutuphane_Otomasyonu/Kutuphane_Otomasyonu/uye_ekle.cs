using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphane_Otomasyonu
{
    public partial class uye_ekle : Form
    {
        public uye_ekle()
        {
            InitializeComponent();
        }

        private void uye_ekle_Load(object sender, EventArgs e)
        {

        }
        public static int uyeid = 0;
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        
        private void btn_uyeekle_Click(object sender, EventArgs e)
        {
            if (kaditxt.Text == "" && sifretxt.Text == "" && txt_sifre2.Text=="")
            {
                MessageBox.Show("Lutfen tüm alanları eksizksiz doldurun");
            }
            else
            {
                if(sifretxt.Text==txt_sifre2.Text)
                {
                    baglanti.Open();

                    SqlCommand login = new SqlCommand("insert into tbl_login (username,sifre,yetki) values(@a1,@a2,@a3); SELECT SCOPE_IDENTITY()", baglanti);
                    login.Parameters.AddWithValue("@a1", kaditxt.Text);
                    login.Parameters.AddWithValue("@a2", sifretxt.Text);
                    login.Parameters.AddWithValue("@a3", "Uye");
                    login.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand asd = new SqlCommand("select uyeid from tbl_login where username=@p1 and sifre=@p2", baglanti);
                    asd.Parameters.AddWithValue("@p1", kaditxt.Text);
                    asd.Parameters.AddWithValue("@p2", sifretxt.Text);
                    SqlDataReader reader = asd.ExecuteReader();
                    while (reader.Read())
                    {
                        uyeid = (int)reader["uyeid"];
                    }
                    baglanti.Close();
                    yenile();
                    uye_bilgileri uye_Bilgileri = new uye_bilgileri();
                    uye_Bilgileri.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Şifreler birbiri ile uyuşmuyor !");
                    yenile();
                }
                
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Ana_Ekran ana_Ekran = new Ana_Ekran();
            ana_Ekran.Show();
            this.Close();
        }
        public void yenile()
        {
            kaditxt.Text = "";
            sifretxt.Text = "";
            txt_sifre2.Text = "";
        }
    }
}
