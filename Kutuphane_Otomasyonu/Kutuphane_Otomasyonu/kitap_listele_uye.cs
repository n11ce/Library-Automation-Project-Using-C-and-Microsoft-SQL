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
    public partial class kitap_listele_uye : Form
    {
        public kitap_listele_uye()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        string sorgu;
        string ad;
        string tur;
        string yazar;
        string yayin;
        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "exec kitap_rafta_1";
                SqlCommand commandlist = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(commandlist);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenemedi.");
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
            
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            uye_paneli uye_Paneli = new uye_paneli();
            uye_Paneli.Show();
            this.Close();
        }

        private void kitap_listele_uye_Load(object sender, EventArgs e)
        {
            string sorgu = "exec kitap_rafta_1";
            SqlCommand commandlist = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(commandlist);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
            
            SqlCommand doldur = new SqlCommand("SELECT *" +
               "FROM tbl_kitaplar join tbl_yazar on tbl_kitaplar.yazarid=tbl_yazar.yazarid " +
               "join tbl_yayinevi on tbl_kitaplar.yayineviid = tbl_yayinevi.yayineviid", baglanti);

            baglanti.Open();
            SqlDataReader reader = doldur.ExecuteReader();
            while (reader.Read())
            {
                if(!combo_kitaptur.Items.Contains(reader["tur"]))
                    combo_kitaptur.Items.Add(reader["tur"]);
                if(!combo_yayin.Items.Contains(reader["yayinevi_ad"]))
                    combo_yayin.Items.Add(reader["yayinevi_ad"]);
                if(!combo_yazar.Items.Contains(reader["yazar_ad"]))
                    combo_yazar.Items.Add(reader["yazar_ad"]);
            }
            baglanti.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    string sorgu = "select barkodno, kitapadi, tur, sayfasayisi, yazar_ad, yayinevi_ad, durum " +
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
                    commandlist.Parameters.AddWithValue("@a0", txt_kitapadı.Text);
                    commandlist.Parameters.AddWithValue("@a1", combo_kitaptur.Text);
                    commandlist.Parameters.AddWithValue("@a2", combo_yazar.Text);
                    commandlist.Parameters.AddWithValue("@a3", combo_yayin.Text);
                    SqlDataAdapter da = new SqlDataAdapter(commandlist);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
                }
                else
                {
                    string sorgu = "select barkodno, kitapadi, tur, sayfasayisi, yazar_ad, yayinevi_ad, durum " +
                        "from tbl_kitaplar join tbl_yazar on tbl_kitaplar.yazarid=tbl_yazar.yazarid join " +
                        "tbl_yayinevi on tbl_kitaplar.yayineviid=tbl_yayinevi.yayineviid where durum='Rafta Değil'";

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
                    commandlist.Parameters.AddWithValue("@a0", txt_kitapadı.Text);
                    commandlist.Parameters.AddWithValue("@a1", combo_kitaptur.Text);
                    commandlist.Parameters.AddWithValue("@a2", combo_yazar.Text);
                    commandlist.Parameters.AddWithValue("@a3", combo_yayin.Text);
                    SqlDataAdapter da = new SqlDataAdapter(commandlist);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata ile karışlaşıldı !");
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
