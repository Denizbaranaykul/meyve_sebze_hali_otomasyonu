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

                // SQL sorgusu: ogrenci_bilgi tablosundan veya yonetici_bilgi tablosundan girilen T.C ve sifre de�erlerine sahip kayd� bul.

                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);

                // DataAdapter ile sorgu sonucunu DataTable i�ine dolduruyoruz.
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    // S�tun adlar�n� kullanarak eri�im:
                    int id = Convert.ToInt32(row["id"]);
                    string telefon = row["telefon"].ToString();
                    string isim = row["isim"].ToString();
                    string soyIsim = row["soy_isim"].ToString();
                    string adres = row["adres"].ToString();

                }

                //coutnlar0 dan b�y�kse b�yle bir kullan�c� bulunmu� olur tc zaten uniqe 
                //��renci giri�i
                if (dt.Rows.Count > 0 && sql == "SELECT * FROM kay�t WHERE telefon = @telefon AND sifre = @sifre")
                {
                    // giri� yap�yoz
                    Global.Conn = conn;
                    Global.Cmd = cmd;
                    Global.Adapter = adapter;
                    Global.Dt = dt;



                    ana_sayfa ana_Sayfa = new ana_sayfa();
                    ana_Sayfa.Show();
                    this.Hide();

                }
                //y�netici bilgi sistemine giri�
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
                    MessageBox.Show("Kullan�c� ad� veya �ifre yanl��");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();//sql sorgusunu kapat�yoz
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//��renci giri�i tikliyse �al��s�n
            {
                if (!string.IsNullOrEmpty(txt_telefon.Text) && !string.IsNullOrEmpty(txt_sifre.Text))//textboxlar bo� veya null de�ilse �al��s�n
                {
                    string sql = "SELECT * FROM kay�t WHERE telefon = @telefon AND sifre = @sifre";//��renci bilgi i�in sorgu komutu
                    girmek(sql);
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre bo�");
                }
            }
            else if (radioButton2.Checked) //y�netici giri�i tikliyse �al��s�n
            {
                string sql2 = "SELECT * FROM yonetici WHERE telefon = @Tc AND sifre = @sifre";// y�netici bilgi i�in sorgu komutu
                girmek(sql2);
            }
            else
            {
                MessageBox.Show("Giri� tipini se�memi�siniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.Conn = conn;
            kay�t_ol kay�t = new kay�t_ol();
            kay�t.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
