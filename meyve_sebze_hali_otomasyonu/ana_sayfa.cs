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
        private void ekle(string isim, int fiyat)
        {
            checkedListBox1.Items.Add("1 adet " + isim);
            toplam_fiyat += fiyat;
            lbl_toplam.Text = fiyat + " TL";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ekle("elma", elma);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ekle("armut", armut);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ekle("portakal", portakal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ekle("mandalina", mandalina);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekle("greyfurt", greyfurt);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ekle("ananas", ananas);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ekle("cilek", cilek);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ekle("muz", muz);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ekle("kiraz", kiraz);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ekle("ayva", ayva);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ekle("erik", erik);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ekle("hurma", hurma);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ekle("patates", patates);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ekle("fasulye", fasulye);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ekle("bezelye", bezelye);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ekle("patlıcan", patlıcan);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ekle("domates", domates);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ekle("salatalık", salatalık);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ekle("ıspanak", ıspanak);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ekle("marul", marul);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ekle("sogan", sogan);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ekle("sarımsak", sarımsak);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ekle("pırasa", pırasa);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ekle("turp", turp);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ekle("elma suyu", elma_suyu);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ekle("portakal suyu", portakal_suyu);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ekle("nar suyu", nar_suyu);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ekle("cilekli yogurt", cilekli_yogurt);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ekle("orman meyveli yogurt", orman_meyveli_yogurt);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ekle("elma sirkesi", elma_sirkesi);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ekle("uzum sirkesi", uzum_sirkesi);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ekle("domates salcası", domates_salcası);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            ekle("biber salcasi", biber_salcasi);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            ekle("cilek receli", cilek_receli);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            ekle("visne receli", visne_receli);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ekle("donmus meyveler", donmus_meyveler);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            ekle("bamya konservesi", bamya_konservesi);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            ekle("bezelye konservesi", bezelye_konserversi);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            ekle("fasulye konservesi", fasulye_konservesi);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            ekle("garnitur", garnitur);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            ekle("domates tursu", domates_tursu);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            ekle("salatalık tursu", saltalık_tursu);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            ekle("biber tursu", biber_tursu);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            ekle("pancar tursu", pancar_tursu);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            ekle("lahana tursu", lahana_tursu);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            // Önce silinecek item'ları al (kopyalayarak çünkü silerken liste bozulur)
            var secilenler = checkedListBox1.CheckedItems.Cast<string>().ToList();

            foreach (string item in secilenler)
            {
                // "1 adet elma" → "elma"
                string urun = item.Replace("1 adet ", "").Trim().ToLower();

                int fiyat = 0;


                switch (urun)
                {
                    case "elma": fiyat = elma; break;
                    case "armut": fiyat = armut; break;
                    case "portakal": fiyat = portakal; break;
                    case "mandalina": fiyat = mandalina; break;
                    case "greyfurt": fiyat = greyfurt; break;
                    case "ananas": fiyat = ananas; break;
                    case "cilek": fiyat = cilek; break;
                    case "muz": fiyat = muz; break;
                    case "kiraz": fiyat = kiraz; break;
                    case "ayva": fiyat = ayva; break;
                    case "erik": fiyat = erik; break;
                    case "hurma": fiyat = hurma; break;


                    case "patates": fiyat = patates; break;
                    case "fasulye": fiyat = fasulye; break;
                    case "bezelye": fiyat = bezelye; break;
                    case "patlıcan": fiyat = patlıcan; break;
                    case "domates": fiyat = domates; break;
                    case "salatalık": fiyat = salatalık; break;
                    case "ıspanak": fiyat = ıspanak; break;
                    case "marul": fiyat = marul; break;
                    case "sogan": fiyat = sogan; break;
                    case "sarımsak": fiyat = sarımsak; break;

                    case "pırasa": fiyat = pırasa; break;
                    case "turp": fiyat = turp; break;

                    case "elma_suyu": fiyat = elma_suyu; break;
                    case "portakal_suyu": fiyat = portakal_suyu; break;
                    case "nar_suyu": fiyat = nar_suyu; break;

                    case "cilekli_yogurt": fiyat = cilekli_yogurt; break;
                    case "orman_meyveli_yogurt": fiyat = orman_meyveli_yogurt; break;

                    case "elma_sirkesi": fiyat = elma_sirkesi; break;
                    case "uzum_sirkesi": fiyat = uzum_sirkesi; break;

                    case "domates_salcası": fiyat = domates_salcası; break;
                    case "biber_salcasi": fiyat = biber_salcasi; break;

                    case "cilek_receli": fiyat = cilek_receli; break;
                    case "visne_receli": fiyat = visne_receli; break;

                    case "donmus_meyveler": fiyat = donmus_meyveler; break;

                    case "bamya_konservesi": fiyat = bamya_konservesi; break;
                    case "bezelye_konserversi": fiyat = bezelye_konserversi; break;
                    case "fasulye_konservesi": fiyat = fasulye_konservesi; break;

                    case "garnitur": fiyat = garnitur; break;

                    case "domates_tursu": fiyat = domates_tursu; break;
                    case "saltalık_tursu": fiyat = saltalık_tursu; break;
                    case "biber_tursu": fiyat = biber_tursu; break;
                    case "pancar_tursu": fiyat = pancar_tursu; break;
                    case "lahana_tursu": fiyat = lahana_tursu; break;
                }


                toplam_fiyat -= fiyat;

                // Listedeki item'ı sil
                checkedListBox1.Items.Remove(item);
            }


            lbl_toplam.Text = toplam_fiyat + " TL";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            odeme odeme=new odeme();
            checkedListBox1.Items.Clear();
            odeme.Show();
        }
    }
}
