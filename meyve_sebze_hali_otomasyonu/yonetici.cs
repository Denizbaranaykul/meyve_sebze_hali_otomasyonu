using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace meyve_sebze_hali_otomasyonu
{
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
            
        }

       
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            if (!int.TryParse(txt_fiyat.Text, out int yeniFiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                return;
            }

            string secilenUrun = comboBox1.SelectedItem.ToString();

            // SQL sorgusu: Dinamik sütun adı kullanılacak
            string query = $"UPDATE fiyatlar SET [{secilenUrun}] = @fiyat";


            try
            {
                Form1.Global.Conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, Form1.Global.Conn))
                {
                    cmd.Parameters.AddWithValue("@fiyat", yeniFiyat);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Fiyat başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            string secilenUrun = comboBox1.SelectedItem.ToString();

            string query = $"SELECT [{secilenUrun}] FROM fiyatlar";

            using (SqlConnection conn = new SqlConnection("connection_string_buraya"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            txt_fiyat.Text = result.ToString();
                        }
                        else
                        {
                            txt_fiyat.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fiyat alınırken hata oluştu: " + ex.Message);
                }
            }
        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            string[] urunler = {
        "elma", "armut", "portakal", "mandalina", "greyfurt", "ananas", "cilek", "muz", "kiraz", "ayva", "erik", "hurma",
        "patates", "fasulye", "bezelye", "patlıcan", "domates", "salatalık", "ıspanak", "marul", "sogan", "sarımsak",
        "pırasa", "turp", "elma_suyu", "portakal_suyu", "nar_suyu", "cilekli_yogurt", "orman_meyveli_yogurt",
        "elma_sirkesi", "uzum_sirkesi", "domates_salcası", "biber_salcasi", "cilek_receli", "visne_receli",
        "donmus_meyveler", "bamya_konservesi", "bezelye_konserversi", "fasulye_konservesi", "garnitur",
        "domates_tursu", "saltalık_tursu", "biber_tursu", "pancar_tursu", "lahana_tursu"
    };

            comboBox1.Items.AddRange(urunler);
        }
    }
}
