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
    public partial class kitap_ekle : Form
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        public kitap_ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_barkod.Text=="" || txt_kitapadı.Text=="" || txt_kitapsayfa.Text=="" || txt_kitapyayınevi.Text==""||
                txt_kitapyazar.Text=="" || combo_kitaptur.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
            else
            {
                try
                {
                    int yazar = kontrol_yazar(txt_kitapyazar.Text);
                    int yayinevi = kontrol_yayin_evi(txt_kitapyayınevi.Text);
                    if(yazar==0 || yayinevi == 0)
                    {
                        MessageBox.Show("yazar veya yayin evi hatası.");
                    }
                    else
                    {
                        baglanti.Open();
                        SqlCommand ekle = new SqlCommand("insert into tbl_kitaplar(barkodno,kitapadi,tur,sayfasayisi,durum,yazarid,yayineviid) values(@a0,@a1,@a2,@a3,@a4,@a5,@a6)", baglanti);
                        ekle.Parameters.AddWithValue("@a0", Convert.ToInt32(txt_barkod.Text));
                        ekle.Parameters.AddWithValue("@a1", txt_kitapadı.Text);
                        ekle.Parameters.AddWithValue("@a2", combo_kitaptur.Text);
                        ekle.Parameters.AddWithValue("@a3", Convert.ToInt32(txt_kitapsayfa.Text));
                        ekle.Parameters.AddWithValue("@a4", "Rafta");
                        ekle.Parameters.AddWithValue("@a5", yazar);
                        ekle.Parameters.AddWithValue("@a6", yayinevi);
                        ekle.ExecuteNonQuery();
                        baglanti.Close();
                        yenile();
                        MessageBox.Show("Kitap Başarıyla Eklendi");
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("kitap eklenemedi !");
                }
                finally
                {
                    baglanti.Close();
                }
                
            }
            

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yonetim_paneli yonetim_Paneli = new yonetim_paneli();
            yonetim_Paneli.Show();
            this.Close();
        }

        private int kontrol_yazar(string yazar)
        {
            try 
            {
                baglanti.Open();
                SqlCommand yazarekle = new SqlCommand("yazarekle", baglanti);
                yazarekle.CommandType = CommandType.StoredProcedure;
                yazarekle.Parameters.Add(new SqlParameter("@yazar", SqlDbType.NVarChar, 255) { Value = yazar });
                SqlParameter returnParameter = yazarekle.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                yazarekle.ExecuteNonQuery();
                baglanti.Close();

                return (int)returnParameter.Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı.");
            }
            finally
            {
                baglanti.Close();
            }
            return 0;
            
        }
        private int kontrol_yayin_evi(string yayinevi)
        {
            try
            {
                baglanti.Open();
                SqlCommand yazarekle = new SqlCommand("yayineviekle", baglanti);
                yazarekle.CommandType = CommandType.StoredProcedure;
                yazarekle.Parameters.Add(new SqlParameter("@yayin", SqlDbType.NVarChar, 255) { Value = yayinevi });
                SqlParameter returnParameter = yazarekle.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                yazarekle.ExecuteNonQuery();
                baglanti.Close();

                return (int)returnParameter.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı.");
                
            }
            finally
            { 
                baglanti.Close();
            }

            return 0;
        }
        private void yenile()
        {
            txt_barkod.Clear();
            txt_kitapadı.Clear();
            txt_kitapsayfa.Clear();
            txt_kitapyayınevi.Clear();
            txt_kitapyazar.Clear();
            combo_kitaptur.Text = "";
        }
    }
}
