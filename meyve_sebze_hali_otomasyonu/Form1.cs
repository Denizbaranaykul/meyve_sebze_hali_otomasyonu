using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace meyve_sebze_hali_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=meyve_sebze_hal;Uid=root;Pwd=12345");

        public static class Global
        {

            public static MySqlConnection Conn { get; set; }
            public static MySqlCommand Cmd { get; set; }
            public static MySqlDataAdapter Adapter { get; set; }
            public static DataTable Dt { get; set; }
        }
        private void girmek(string sql)
        {
            try
            {
                conn.Open();

                // SQL sorgusu: ogrenci_bilgi tablosundan veya yonetici_bilgi tablosundan girilen T.C ve sifre deðerlerine sahip kaydý bul.

                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);

                // DataAdapter ile sorgu sonucunu DataTable içine dolduruyoruz.
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    // Sütun adlarýný kullanarak eriþim:
                    int id = Convert.ToInt32(row["id"]);
                    string telefon = row["telefon"].ToString();
                    string isim = row["isim"].ToString();
                    string soyIsim = row["soy_isim"].ToString();
                    string adres = row["adres"].ToString();

                }

                //coutnlar0 dan büyükse böyle bir kullanýcý bulunmuþ olur tc zaten uniqe 
                //öðrenci giriþi
                if (dt.Rows.Count > 0 && sql == "SELECT * FROM kayýt WHERE telefon = @telefon AND sifre = @sifre")
                {
                    // giriþ yapýyoz
                    Global.Conn = conn;
                    Global.Cmd = cmd;
                    Global.Adapter = adapter;
                    Global.Dt = dt;



                    ana_sayfa ana_Sayfa = new ana_sayfa();
                    ana_Sayfa.Show();
                    this.Hide();

                }
                //yönetici bilgi sistemine giriþ
                else if (dt.Rows.Count > 0 && sql == "SELECT * FROM yonetici WHERE telefon = @telefon AND sifre = @sifre")
                {
                    Global.Conn = conn;
                    Global.Cmd = cmd;
                    Global.Adapter = adapter;
                    Global.Dt = dt;

                    yonetici yoneticii = new yonetici();
                    yoneticii.Show();

                    this.Hide();
                    yoneticii.Show();
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre yanlýþ");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();//sql sorgusunu kapatýyoz
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//öðrenci giriþi tikliyse çalýþsýn
            {
                if (!string.IsNullOrEmpty(txt_telefon.Text) && !string.IsNullOrEmpty(txt_sifre.Text))//textboxlar boþ veya null deðilse çalýþsýn
                {
                    string sql = "SELECT * FROM kayýt WHERE telefon = @telefon AND sifre = @sifre";//öðrenci bilgi için sorgu komutu
                    girmek(sql);
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre boþ");
                }
            }
            else if (radioButton2.Checked) //yönetici giriþi tikliyse çalýþsýn
            {
                string sql2 = "SELECT * FROM yonetici WHERE telefon = @Tc AND sifre = @sifre";// yönetici bilgi için sorgu komutu
                girmek(sql2);
            }
            else
            {
                MessageBox.Show("Giriþ tipini seçmemiþsiniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.Conn = conn;
            kayýt_ol kayýt = new kayýt_ol();
            kayýt.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
