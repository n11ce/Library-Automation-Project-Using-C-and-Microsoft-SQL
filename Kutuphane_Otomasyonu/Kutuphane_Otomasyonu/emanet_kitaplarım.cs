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
    public partial class emanet_kitaplarım : Form
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        public static int uyeid = uye_paneli.uyeid;
        public emanet_kitaplarım()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            uye_paneli uye_Paneli = new uye_paneli();
            uye_Paneli.Show();
            this.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand commandlist = new SqlCommand("exec kitap_rafta", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(commandlist);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void emanet_kitaplarım_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            yenile();
            SqlCommand doldur = new SqlCommand("SELECT *" +
               "FROM tbl_kitaplar join tbl_yazar on tbl_kitaplar.yazarid=tbl_yazar.yazarid " +
               "join tbl_yayinevi on tbl_kitaplar.yayineviid = tbl_yayinevi.yayineviid", baglanti);

            baglanti.Open();
            SqlDataReader reader = doldur.ExecuteReader();
            while (reader.Read())
            {
                if (!combo_kitaptur.Items.Contains(reader["tur"]))
                    combo_kitaptur.Items.Add(reader["tur"]);
                if (!combo_yayin.Items.Contains(reader["yayinevi_ad"]))
                    combo_yayin.Items.Add(reader["yayinevi_ad"]);
                if (!combo_yazar.Items.Contains(reader["yazar_ad"]))
                    combo_yazar.Items.Add(reader["yazar_ad"]);
            }
            baglanti.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txt_barkod.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand teslim = new SqlCommand("exec odunc_kitap @a1", baglanti);
            teslim.Parameters.AddWithValue("@a1",uyeid);
            SqlDataAdapter da = new SqlDataAdapter(teslim);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btn_uyeguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand emanet = new SqlCommand("insert into tbl_odunckitap(kitapid,uyeid,baslangictarih,bitistarih,teslim) " +
                    "values(@a0,@a1,@a2,@a3,@a4)", baglanti);
                emanet.Parameters.AddWithValue("@a0", txt_barkod.Text);
                emanet.Parameters.AddWithValue("@a1", uyeid);
                emanet.Parameters.AddWithValue("@a2", dateTimePicker1.Value);
                emanet.Parameters.AddWithValue("@a3", dateTimePicker2.Value);
                emanet.Parameters.AddWithValue("@a4", Convert.ToString("üye id:" + uyeid + " kişi emanet aldı"));
                emanet.ExecuteNonQuery();
                baglanti.Close();
                yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lutfen emanet kitaplarım bölümünden kitap seçin !");
            }
            finally
            {
                baglanti.Close();
            }
           
        }

        public void yenile()
        {
            string sorgu = "exec kitap_rafta";
            SqlCommand commandlist = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(commandlist);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            label10.Text = dataGridView1.RowCount.ToString();
        }

        private void btn_uyesil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sil = new SqlCommand("delete from tbl_odunckitap where oduncid=@a0", baglanti);
                sil.Parameters.AddWithValue("@a0", txt_barkod.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();
                yenile();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lutfen emanet kitaplarım bölümünden kitap seçin !");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "select kitapid as [Kitap ID], kitapadi as [Kitap Adı], tur as [Tür], " +
                                "sayfasayisi as [Sayfa Sayısı], yazar_ad as [Yazar Adı], yayinevi_ad as [Yayın Evi], durum as [Durum]" +
                                    "from tbl_kitaplar join tbl_yazar on tbl_kitaplar.yazarid=tbl_yazar.yazarid join " +
                                    "tbl_yayinevi on tbl_kitaplar.yayineviid=tbl_yayinevi.yayineviid where durum='Rafta'";


                if (!string.IsNullOrEmpty(txt_kitapadı.Text))
                    sorgu += " AND kitapadi = @a0";
                if (!string.IsNullOrEmpty(combo_kitaptur.Text))
                    sorgu += " AND tur = @a1";
                if (!string.IsNullOrEmpty(combo_yazar.Text))
                    sorgu += " AND yazar_ad = @a2";
                if (!string.IsNullOrEmpty(combo_yayin.Text))
                    sorgu += " AND yayinevi_ad = @a3";
                baglanti.Open();
                SqlCommand commandlist = new SqlCommand(sorgu, baglanti);
                if (!string.IsNullOrEmpty(txt_kitapadı.Text))
                    commandlist.Parameters.AddWithValue("@a0", txt_kitapadı.Text);
                if (!string.IsNullOrEmpty(combo_kitaptur.Text))
                    commandlist.Parameters.AddWithValue("@a1", combo_kitaptur.Text);
                if (!string.IsNullOrEmpty(combo_yazar.Text))
                    commandlist.Parameters.AddWithValue("@a2", combo_yazar.Text);
                if (!string.IsNullOrEmpty(combo_yayin.Text))
                    commandlist.Parameters.AddWithValue("@a3", combo_yayin.Text);
                SqlDataAdapter da = new SqlDataAdapter(commandlist);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch(Exception ex)
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
