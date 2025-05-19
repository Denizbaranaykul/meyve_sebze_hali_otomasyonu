using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meyve_sebze_hali_otomasyonu
{
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
            label5.Text += ana_sayfa.toplam_fiyat+" TL";
        }
        private bool TumAlanlarDoluMu()
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox2.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox3.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox4.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TumAlanlarDoluMu())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            MessageBox.Show("Ödeme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ana_sayfa.toplam_fiyat = 0;
            
            this.Close();
        }
    }
}
