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
    public partial class uye_listele : Form
    {
        public uye_listele()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        
        private void btn_listele_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yonetim_paneli panel = new yonetim_paneli();
            panel.Show();
            this.Close();
        }

        private void btn_uyeguncelle_Click(object sender, EventArgs e)
        {
            try{
                SqlCommand guncele = new SqlCommand("UPDATE TB_uyeler SET Ad=@ad, Soyad=@soyad, Sehir=@sehir, Adres=@adres, Telefon=@tel, Mail=@mail Where uyeid=@id", baglanti);
                baglanti.Open();
                guncele.Parameters.AddWithValue("@id", Convert.ToInt32(uyeid.Text));
                guncele.Parameters.AddWithValue("@ad", txt_ad.Text);
                guncele.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                guncele.Parameters.AddWithValue("@adres", txt_adres.Text);
                guncele.Parameters.AddWithValue("@tel", txt_telefon.Text);
                guncele.Parameters.AddWithValue("@mail", txt_mail.Text);
                guncele.Parameters.AddWithValue("@sehir", combo_sehir.SelectedItem.ToString());
                guncele.ExecuteNonQuery();
                SqlCommand user = new SqlCommand("update tbl_login set username=@a0,sifre=@a1 where uyeid=@a2", baglanti);
                user.Parameters.AddWithValue("@a0", txt_kullanıciadi.Text);
                user.Parameters.AddWithValue("@a1", txt_sifre.Text);
                user.Parameters.AddWithValue("@a2", Convert.ToInt32(uyeid.Text));
                user.ExecuteNonQuery();
                baglanti.Close();
                
                if (yetki.Checked==true)
                {
                    baglanti.Open();
                    SqlCommand veri = new SqlCommand("update tbl_login set yetki=@a0 where uyeid=@a1", baglanti);
                    veri.Parameters.AddWithValue("@a0", "Admin");
                    veri.Parameters.AddWithValue("@a1", Convert.ToInt32(uyeid.Text));
                    veri.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();
                    SqlCommand veri = new SqlCommand("update tbl_login set yetki=@a0 where uyeid=@a1", baglanti);
                    veri.Parameters.AddWithValue("@a0", "Uye");
                    veri.Parameters.AddWithValue("@a1", Convert.ToInt32(uyeid.Text));
                    veri.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show(txt_ad.Text + " " + "adlı uye guncellendi");
                guncelle();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Üye güncelleme yapılamadı !");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            uyeid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txt_kullanıciadi.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txt_soyad.Text= dataGridView1.Rows[selected].Cells[5].Value.ToString();
            combo_sehir.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            txt_adres.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
            txt_telefon.Text = dataGridView1.Rows[selected].Cells[8].Value.ToString();
            txt_mail.Text = dataGridView1.Rows[selected].Cells[9].Value.ToString();
            if (yonetim_kontrol(Convert.ToInt32(uyeid.Text)) == "Admin")
            {
                yetki.Checked = true;
            }
            else
            {
                yetki.Checked = false;
            }
        }
        public void yenile()
        {
            uyeid.Text = "*";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_adres.Text = "";
            txt_mail.Text = "";
            txt_telefon.Text = "";
            combo_sehir.Text = "";
            txt_kullanıciadi.Clear();
            txt_sifre.Clear();
            yetki.Checked = false;
        }
        public void guncelle()
        {
            try
            {
                SqlCommand commandlist = new SqlCommand("SELECT * FROM uye_listele", baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(commandlist);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                yenile();
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
        
        private void btn_uyesil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sil = new SqlCommand("delete from TB_uyeler Where uyeid=@id", baglanti);
                baglanti.Open();
                sil.Parameters.AddWithValue("@id", Convert.ToInt32(uyeid.Text));
                sil.ExecuteNonQuery();
                MessageBox.Show(txt_ad.Text + " " + "adlı üye başarıyla silindi.");
                baglanti.Close();
                guncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye silinemedi !");
            }
            finally
            {
                baglanti.Close();
            }
           
        }

        private void uye_listele_Load(object sender, EventArgs e)
        {
            guncelle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string yonetim_kontrol(int uyeid)
        {
            baglanti.Open();
            string yetki = "Uye";
            SqlCommand veri = new SqlCommand("select * from tbl_login where uyeid=@a0",baglanti);
            veri.Parameters.AddWithValue("@a0",uyeid);
            SqlDataReader reader = veri.ExecuteReader();
            while (reader.Read())
            {
                yetki = reader["yetki"].ToString();
            }
            baglanti.Close();
            return yetki;
        }
    }
}
