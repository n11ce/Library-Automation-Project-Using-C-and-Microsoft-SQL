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
    public partial class kitap_listele : Form
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        public kitap_listele()
        {
            InitializeComponent();
        }

        private void kitap_listele_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yonetim_paneli yonetim_Paneli = new yonetim_paneli();
            yonetim_Paneli.Show();
            this.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            yenile();
        }
        private void yenile()
        {
            try
            {
                string sorgu = "select * from kitap_listele";
                SqlCommand commandlist = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(commandlist);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                txt_barkod.Clear();
                txt_kitapadı.Clear();
                txt_kitapsayfa.Clear();
                txt_kitapyayınevi.Clear();
                txt_kitapyazar.Clear();
                comboBox1.Text = "";
                combo_kitaptur.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı.");
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            try 
            {
                int deger = Convert.ToInt32(txt_barkod.Text);
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update tbl_kitaplar set kitapadi=@a0,tur=@a1,sayfasayisi=@a2,durum=@a3 where kitapid=@a4", baglanti);
                guncelle.Parameters.AddWithValue("@a0", txt_kitapadı.Text);
                guncelle.Parameters.AddWithValue("@a1", combo_kitaptur.Text);
                guncelle.Parameters.AddWithValue("@a2", Convert.ToInt32(txt_kitapsayfa.Text));
                guncelle.Parameters.AddWithValue("@a3", comboBox1.Text);
                guncelle.Parameters.AddWithValue("@a4", deger);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                yazarupdate(deger);
                yayinupdate(deger);
                MessageBox.Show("Kitap ID: " + deger + " Kitap başarıyla güncellendi.");
                yenile();
            }
            catch(Exception ex)
            {
                MessageBox.Show("kitap güncellenemedi !" + ex);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            try
            {
                int deger = Convert.ToInt32(txt_barkod.Text);
                baglanti.Open();
                SqlCommand sil = new SqlCommand("delete from tbl_kitaplar where kitapid=@a0", baglanti);
                sil.Parameters.AddWithValue("@a0", deger);
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap ID: " + deger + " Kitap başarıyla silindi.");
                yenile();

            }
            catch (Exception ex)
            {
                MessageBox.Show("kitap silinemedi !" + ex);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txt_barkod.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txt_kitapadı.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            combo_kitaptur.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txt_kitapsayfa.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            txt_kitapyayınevi.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            txt_kitapyazar.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();

        }
        private int yazarbul(int kitapid)
        {
            int deger=0;
            baglanti.Open();
            SqlCommand yazar = new SqlCommand("select tbl_kitaplar.yazarid from tbl_kitaplar join tbl_yazar on tbl_kitaplar.yazarid=tbl_yazar.yazarid where kitapid=@a0", baglanti);
            yazar.Parameters.AddWithValue("@a0", kitapid);
            SqlDataReader reader = yazar.ExecuteReader();
            while (reader.Read()){
                deger = Convert.ToInt32(reader["yazarid"]);
            }
            baglanti.Close();
            return deger;
        }
        private int yayinevibul(int kitapid)
        {
            int deger = 0;
            baglanti.Open();
            SqlCommand yazar = new SqlCommand("select tbl_kitaplar.yayineviid from tbl_kitaplar join tbl_yayinevi on tbl_kitaplar.yayineviid=tbl_yayinevi.yayineviid where kitapid=@a0", baglanti);
            yazar.Parameters.AddWithValue("@a0", kitapid);
            SqlDataReader reader = yazar.ExecuteReader();
            while (reader.Read())
            {
                deger= Convert.ToInt32(reader["yayineviid"]);
            }
            baglanti.Close();
            return deger;
        }
        private void yazarupdate(int kitapid)
        {
            int deger = yazarbul(kitapid);
            baglanti.Open();
            SqlCommand yazar = new SqlCommand("update tbl_yazar set yazar_ad=@a0 where yazarid=@a1", baglanti);
            yazar.Parameters.AddWithValue("@a0", txt_kitapyazar.Text);
            yazar.Parameters.AddWithValue("@a1", deger);
            yazar.ExecuteNonQuery();
            baglanti.Close();
        }
        private void yayinupdate(int kitapid)
        {
            int deger = yayinevibul(kitapid);
            baglanti.Open();
            SqlCommand yayin = new SqlCommand("update tbl_yayinevi set yayinevi_ad=@a0 where yayineviid=@a1", baglanti);
            yayin.Parameters.AddWithValue("@a0", txt_kitapyayınevi.Text);
            yayin.Parameters.AddWithValue("@a1", deger);
            baglanti.Close();
        }
    }
}
