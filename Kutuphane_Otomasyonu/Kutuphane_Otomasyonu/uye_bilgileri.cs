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
    
    public partial class uye_bilgileri : Form
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        public static int uyeid = 0;

        public int bilgiKontrol()
        {
            baglanti.Open();
            SqlCommand veri = new SqlCommand("select * from TB_Uyeler where uyeid=@p0", baglanti);
            veri.Parameters.AddWithValue("@p0", uyeid);
            SqlDataReader reader = veri.ExecuteReader();
            if (reader.Read())
            {
                baglanti.Close();
                return 1;
            }
            else
            {

                baglanti.Close();
                return 0;
            }
            return 0;
        }


        public uye_bilgileri()
        {
            InitializeComponent();
        }

        private void btn_uyeekle1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bilgiKontrol() == 0)
                {
                    if (txt_ad.Text == "" && txt_soyad.Text == "" &&
                                               txt_adres.Text == "" && txt_telefon.Text == ""
                                               && txt_mail.Text == "" && combo_sehir.Text == "")
                    {
                        MessageBox.Show("Lutfen tum alanları doldurunuz !");
                    }
                    else
                    {
                        baglanti.Open();
                        SqlCommand giris = new SqlCommand("insert into TB_Uyeler (uyeid,Ad,Soyad,Sehir,Adres," +
                            "Telefon,Mail) values(@a0,@a1,@a2,@a3,@a4,@a5,@a6)", baglanti);
                        giris.Parameters.AddWithValue("@a0", uyeid);
                        giris.Parameters.AddWithValue("@a1", txt_ad.Text);
                        giris.Parameters.AddWithValue("@a2", txt_soyad.Text);
                        giris.Parameters.AddWithValue("@a3", combo_sehir.Text);
                        giris.Parameters.AddWithValue("@a4", txt_adres.Text);
                        giris.Parameters.AddWithValue("@a5", txt_telefon.Text);
                        giris.Parameters.AddWithValue("@a6", txt_mail.Text);
                        giris.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show(uyeid + "  Üye id'li kullanıcının üye bilgileri kaydedildi.");
                    }
                }
                else if (bilgiKontrol() == 1)
                {
                    if (txt_ad.Text == "" && txt_soyad.Text == "" &&
                                                               txt_adres.Text == "" && txt_telefon.Text == ""
                                                               && txt_mail.Text == "" && combo_sehir.Text == "")
                    {
                        MessageBox.Show("Lutfen tum alanları doldurunuz !");
                    }
                    else
                    {
                        baglanti.Open();
                        SqlCommand giris = new SqlCommand("Update TB_uyeler set Ad=@a1, Soyad=@a2,Sehir=@a3," +
                            "Adres=@a4,Telefon=@a5,Mail=@a6 WHERE uyeid=@a0", baglanti);
                        giris.Parameters.AddWithValue("@a0", uyeid);
                        giris.Parameters.AddWithValue("@a1", txt_ad.Text);
                        giris.Parameters.AddWithValue("@a2", txt_soyad.Text);
                        giris.Parameters.AddWithValue("@a3", combo_sehir.Text);
                        giris.Parameters.AddWithValue("@a4", txt_adres.Text);
                        giris.Parameters.AddWithValue("@a5", txt_telefon.Text);
                        giris.Parameters.AddWithValue("@a6", txt_mail.Text);
                        giris.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show(uyeid + "  Üye id'li kullanıcının üye bilgileri güncellendi.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            
            if (bilgiKontrol()==1)
            {
                uye_paneli uye_Paneli = new uye_paneli();
                uye_Paneli.Show();
                this.Close();
            }
            else
            {

                MessageBox.Show("Lütfen bilgilerinizi doldurunuz!");
            }
        }
            private void uye_bilgileri_Load(object sender, EventArgs e)
        {
            try 
            {
                if (uye_ekle.uyeid == 0)
                {
                    uyeid = uye_paneli.uyeid;
                }
                if (uye_paneli.uyeid == 0)
                {
                    uyeid = uye_ekle.uyeid;
                }

                if (uyeid != 0)
                {

                    baglanti.Open();
                    SqlCommand doldur = new SqlCommand("select Ad,Soyad,Sehir,Adres,Telefon,Mail FROM TB_uyeler WHERE uyeid=@p0", baglanti);
                    doldur.Parameters.AddWithValue("@p0", Convert.ToInt32(uyeid));
                    SqlDataReader reader = doldur.ExecuteReader();
                    while (reader.Read())
                    {
                        txt_ad.Text = reader["Ad"].ToString();
                        txt_soyad.Text = reader["Soyad"].ToString();
                        combo_sehir.Text = reader["Sehir"].ToString();
                        txt_adres.Text = reader["Adres"].ToString();
                        txt_telefon.Text = reader["Telefon"].ToString();
                        txt_mail.Text = reader["Mail"].ToString();
                        break;
                    }
                    baglanti.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı.");
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
