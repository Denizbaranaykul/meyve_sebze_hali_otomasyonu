namespace meyve_sebze_hali_otomasyonu
{
    partial class yonetici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_fiyat = new MaskedTextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(63, 220);
            button1.Name = "button1";
            button1.Size = new Size(151, 48);
            button1.TabIndex = 5;
            button1.Text = "güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(63, 18);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 6;
            label1.Text = "ürünü seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(63, 110);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 7;
            label2.Text = "ürünün fiyatı";
            // 
            // txt_fiyat
            // 
            txt_fiyat.Location = new Point(63, 167);
            txt_fiyat.Mask = "00000";
            txt_fiyat.Name = "txt_fiyat";
            txt_fiyat.Size = new Size(151, 27);
            txt_fiyat.TabIndex = 10;
            txt_fiyat.ValidatingType = typeof(int);
            // 
            // yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(314, 337);
            Controls.Add(txt_fiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "yonetici";
            Text = "yonetici";
            Load += yonetici_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private MaskedTextBox txt_fiyat;
    }
}