using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphane_Otomasyonu
{
    public partial class Ana_Ekran : Form
    {
        public Ana_Ekran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=HUSEYIN-PC;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        public static int uyeid = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" && textBox2.Text == "")
            {
                MessageBox.Show("Lutfen ilgili alanlari doldurunuz.");
            }
            else
            {
                baglanti.Open();
                SqlCommand giris = new SqlCommand("select * from tbl_login Where username=@A1 and sifre=@A2", baglanti);
                giris.Parameters.AddWithValue("@A1",textBox1.Text);
                giris.Parameters.AddWithValue("@A2",textBox2.Text);
                SqlDataReader dt = giris.ExecuteReader();

                if (dt.Read())
                {
                    uyeid = Convert.ToInt32(dt["uyeid"]);
                    string rol = dt["yetki"].ToString();
                    roller(rol);
                }
                else
                {
                    MessageBox.Show("giris basarisiz");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                baglanti.Close();
            }
        }

        private void roller(string rol)
        {
            if (rol == "Admin")
            {
                yonetim_paneli yonetim_Paneli = new yonetim_paneli();
                yonetim_Paneli.Show();
                this.Hide();
                
            }
            if (rol == "Uye")
            {
                uye_paneli uye_Paneli = new uye_paneli();
                uye_Paneli.Show();
                this.Hide();

            }
       
        }
        private void button2_Click(object sender, EventArgs e)
        {
            uye_ekle uye_Ekle = new uye_ekle();
            uye_Ekle.Show();
            this.Hide();
        }
    }
}
