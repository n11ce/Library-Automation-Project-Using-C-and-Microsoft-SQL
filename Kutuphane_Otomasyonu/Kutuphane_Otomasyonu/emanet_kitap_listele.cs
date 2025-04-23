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
    public partial class emanet_kitap_listele : Form
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");

        public emanet_kitap_listele()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yonetim_paneli yonetim_Paneli = new yonetim_paneli();
            yonetim_Paneli.Show();
            this.Close();
        }

        private void emanet_kitap_listele_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("exec emanet_listele", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                string sorgu = "select uyeid as [Üye ID],tbl_kitaplar.kitapid as [Kitap ID],barkodno as [Barkod No],kitapadi as [Kitap Adı],tur as [Tür],sayfasayisi as [Sayfa Sayısı],baslangictarih as [Alış Tarihi],bitistarih as [Bitiş Tarihi],teslim as [Açıklama] from tbl_kitaplar join tbl_odunckitap on tbl_kitaplar.kitapid = tbl_odunckitap.kitapid where 1=1";

                if (!string.IsNullOrEmpty(txt1.Text))
                    sorgu += " AND uyeid=@a0";
                if (!string.IsNullOrEmpty(txt2.Text))
                    sorgu += " AND tbl_kitaplar.kitapid=@a1";

                baglanti.Open();
                SqlCommand ara = new SqlCommand(sorgu, baglanti);

                if (!string.IsNullOrEmpty(txt1.Text))
                    ara.Parameters.AddWithValue("@a0", Convert.ToInt32(txt1.Text));
                if (!string.IsNullOrEmpty(txt2.Text))
                    ara.Parameters.AddWithValue("@a1", Convert.ToInt32(txt2.Text));

                SqlDataAdapter da = new SqlDataAdapter(ara);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu.");
            }
          
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txt1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txt2.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sil = new SqlCommand("delete from tbl_odunckitap where uyeid=@a0 and kitapid=@a1", baglanti);
                baglanti.Open();
                sil.Parameters.AddWithValue("@a0", txt1.Text);
                sil.Parameters.AddWithValue("@a1", txt2.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen tablodan kişi seçin." + ex);
            }
            finally
            {
                baglanti.Close();
                yenile();
            }
        }
        private void yenile()
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("exec emanet_listele", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                object donus;
                int sonuc;

                do
                {
                    baglanti.Open();

                    SqlCommand kontrol = new SqlCommand("SELECT dbo.SuresiGecen()", baglanti);
                    donus = kontrol.ExecuteScalar();

                    if (donus != null && donus != DBNull.Value)
                    {
                        sonuc = (int)donus;

                        SqlCommand sil = new SqlCommand("delete from tbl_odunckitap where kitapid=@a0", baglanti);
                        sil.Parameters.AddWithValue("@a0", sonuc);
                        sil.ExecuteNonQuery();
                    }
                    else
                    {
                        sonuc = -1;
                    }

                    baglanti.Close();
                } while (sonuc != -1);

                MessageBox.Show("Süresi geçen emanetler geri alındı.");
                yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu.");
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}
