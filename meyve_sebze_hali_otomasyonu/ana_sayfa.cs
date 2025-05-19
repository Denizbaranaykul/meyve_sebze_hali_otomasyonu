using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace meyve_sebze_hali_otomasyonu
{
    public partial class ana_sayfa : Form
    {
        public ana_sayfa()
        {
            InitializeComponent();
            

        }
        public static int toplam_fiyat = 0;
        public static int elma, armut, portakal, mandalina, greyfurt, ananas, cilek, muz, kiraz, ayva, erik, hurma;
        public static int patates, fasulye, bezelye, patlıcan, domates, salatalık, ıspanak, marul, sogan, sarımsak;
        public static int pırasa, turp, elma_suyu, portakal_suyu, nar_suyu, cilekli_yogurt, orman_meyveli_yogurt;
        public static int elma_sirkesi, uzum_sirkesi, domates_salcası, biber_salcasi, cilek_receli, visne_receli;
        public static int donmus_meyveler, bamya_konservesi, bezelye_konserversi, fasulye_konservesi, garnitur;
        public static int domates_tursu, saltalık_tursu, biber_tursu, pancar_tursu, lahana_tursu;


        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }
        private void ekle(string isim,int fiyat)
        {
            checkedListBox1.Items.Add("1 adet " + isim);
            toplam_fiyat += fiyat;
            lbl_toplam.Text = fiyat + " TL";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FiyatlariLabelaYaz()
        {
            lbl_elma.Text += elma + " TL";
            lbl_armut.Text += armut + " TL";
            lbl_portakal.Text += portakal + " TL";
            lbl_mandalina.Text = mandalina + " TL";
            lbl_greyfurt.Text += greyfurt + " TL";
            lbl_ananas.Text += ananas + " TL";
            lbl_cilek.Text += cilek + " TL";
            lbl_muz.Text += muz + " TL";
            lbl_kiraz.Text += kiraz + " TL";
            lbl_ayva.Text += ayva + " TL";
            lbl_erik.Text += erik + " TL";
            lbl_hurma.Text += hurma + " TL";

            lbl_patates.Text += patates + " TL";
            lbl_fasulye.Text += fasulye + " TL";
            lbl_bezelye.Text += bezelye + " TL";
            lbl_patlıcan.Text += patlıcan + " TL";
            lbl_domates.Text += domates + " TL";
            lbl_salatalık.Text += salatalık + " TL";
            lbl_ıspanak.Text += ıspanak + " TL";
            lbl_marul.Text += marul + " TL";
            lbl_sogan.Text += sogan + " TL";
            lbl_sarımsak.Text += sarımsak + " TL";

            lbl_pırasa.Text += pırasa + " TL";
            lbl_turp.Text += turp + " TL";

            lbl_elma_suyu.Text += elma_suyu + " TL";
            lbl_portakal_suyu.Text += portakal_suyu + " TL";
            lbl_nar_suyu.Text += nar_suyu + " TL";
                
            lbl_cilek_yogurt.Text += cilekli_yogurt + " TL";
            lbl_orman_meyve.Text += orman_meyveli_yogurt + " TL";

            lbl_elmsirke.Text += elma_sirkesi + " TL";
            lbl_uzum_sirke.Text += uzum_sirkesi + " TL";

            lbl_domat_salca.Text += domates_salcası + " TL";
            lbl_biber_salca.Text += biber_salcasi + " TL";
                
            lbl_cilek_salca.Text += cilek_receli + " TL";
            lbl_visne_salca.Text += visne_receli + " TL";

            lbl_dm.Text += donmus_meyveler + " TL";

            lbl_bamya_konserve.Text += bamya_konservesi + " TL";
            lbl_bzelye_konserve.Text += bezelye_konserversi + " TL";
            fasulye_konserve.Text += fasulye_konservesi + " TL";

            lbl_garnitur.Text += garnitur + " TL";

            lbl_domat_tursu.Text += domates_tursu + " TL";
            lbl_salatalık_tursu.Text += saltalık_tursu + " TL";
            lbl_biber_tursu.Text += biber_tursu + " TL";
            lbl_pancar_tursu.Text += pancar_tursu + " TL";
            lbl_lahana_tursu.Text += lahana_tursu + " TL";
        }   



        private void ana_sayfa_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM fiyatlar LIMIT 1";
            MySqlCommand command = new MySqlCommand(query, Form1.Global.Conn);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                     elma = reader.GetInt32("elma");
                     armut = reader.GetInt32("armut");
                     portakal = reader.GetInt32("portakal");
                     mandalina = reader.GetInt32("mandalina");
                     greyfurt = reader.GetInt32("greyfurt");
                     ananas = reader.GetInt32("ananas");
                     cilek = reader.GetInt32("cilek");
                     muz = reader.GetInt32("muz");
                     kiraz = reader.GetInt32("kiraz");
                     ayva = reader.GetInt32("ayva");
                     erik = reader.GetInt32("erik");
                     hurma = reader.GetInt32("hurma");
                     patates = reader.GetInt32("patates");
                     fasulye = reader.GetInt32("fasulye");
                     bezelye = reader.GetInt32("bezelye");
                     patlıcan = reader.GetInt32("patlıcan");
                     domates = reader.GetInt32("domates");
                     salatalık = reader.GetInt32("salatalık");
                     ıspanak = reader.GetInt32("ıspanak");
                     marul = reader.GetInt32("marul");
                     sogan = reader.GetInt32("sogan");
                     sarımsak = reader.GetInt32("sarımsak");
                     pırasa = reader.GetInt32("pırasa");
                     turp = reader.GetInt32("turp");
                     elma_suyu = reader.GetInt32("elma_suyu");
                     portakal_suyu = reader.GetInt32("portakal_suyu");
                     nar_suyu = reader.GetInt32("nar_suyu");
                     cilekli_yogurt = reader.GetInt32("cilekli_yogurt");
                     orman_meyveli_yogurt = reader.GetInt32("orman_meyveli_yogurt");
                     elma_sirkesi = reader.GetInt32("elma_sirkesi");
                     uzum_sirkesi = reader.GetInt32("uzum_sirkesi");
                     domates_salcası = reader.GetInt32("domates_salcası");
                     biber_salcasi = reader.GetInt32("biber_salcasi");
                     cilek_receli = reader.GetInt32("cilek_receli");
                     visne_receli = reader.GetInt32("visne_receli");
                     donmus_meyveler = reader.GetInt32("donmus_meyveler");
                     bamya_konservesi = reader.GetInt32("bamya_konservesi");
                     bezelye_konserversi = reader.GetInt32("bezelye_konserversi");
                     fasulye_konservesi = reader.GetInt32("fasulye_konservesi");
                     garnitur = reader.GetInt32("garnitur");
                     domates_tursu = reader.GetInt32("domates_tursu");
                     saltalık_tursu = reader.GetInt32("saltalık_tursu");
                     biber_tursu = reader.GetInt32("biber_tursu");
                     pancar_tursu = reader.GetInt32("pancar_tursu");
                     lahana_tursu = reader.GetInt32("lahana_tursu");


                }
                Form1.Global.Conn.Close();
                FiyatlariLabelaYaz();

            }
        }
    }
}
