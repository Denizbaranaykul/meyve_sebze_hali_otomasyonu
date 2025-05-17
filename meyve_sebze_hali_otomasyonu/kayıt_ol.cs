using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQL.Data;
namespace meyve_sebze_hali_otomasyonu
{
    public partial class kayıt_ol : Form
    {
        public kayıt_ol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Global.Conn.Open();
            string sql = "INSERT INTO kayıt (isim,soy_isim,adres,sifre,telefon) VALUES(@ad,@soyad,@adres,@sifre,@telefon)";
            MySqlCommand cmd = new MySqlCommand(sql,Form1.Global.Conn);
            cmd.Parameters.AddWithValue("@ad", txt_isim.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_soyisim.Text);
            cmd.Parameters.AddWithValue("@adres", txt_adres.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            cmd.ExecuteNonQuery();
            Form1.Global.Conn.Close();
            MessageBox.Show("başarı ile kaydedildi");
            this.Close();
            Form1.Global.Conn.Close();
        }
    }
}
