namespace meyve_sebze_hali_otomasyonu
{
    partial class kayıt_ol
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
            label1 = new Label();
            txt_isim = new TextBox();
            txt_soyisim = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_telefon = new MaskedTextBox();
            txt_adres = new RichTextBox();
            button1 = new Button();
            txt_sifre = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(45, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 35);
            label1.TabIndex = 0;
            label1.Text = "isim";
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(45, 86);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(274, 27);
            txt_isim.TabIndex = 1;
            // 
            // txt_soyisim
            // 
            txt_soyisim.Location = new Point(45, 173);
            txt_soyisim.Name = "txt_soyisim";
            txt_soyisim.Size = new Size(274, 27);
            txt_soyisim.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(45, 116);
            label2.Name = "label2";
            label2.Size = new Size(105, 35);
            label2.TabIndex = 2;
            label2.Text = "soy isim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(45, 212);
            label3.Name = "label3";
            label3.Size = new Size(92, 35);
            label3.TabIndex = 4;
            label3.Text = "telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(45, 308);
            label4.Name = "label4";
            label4.Size = new Size(76, 35);
            label4.TabIndex = 6;
            label4.Text = "adres";
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(45, 265);
            txt_telefon.Mask = "(999) 000-0000";
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(274, 27);
            txt_telefon.TabIndex = 8;
            // 
            // txt_adres
            // 
            txt_adres.Location = new Point(45, 346);
            txt_adres.Name = "txt_adres";
            txt_adres.Size = new Size(274, 120);
            txt_adres.TabIndex = 9;
            txt_adres.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(45, 594);
            button1.Name = "button1";
            button1.Size = new Size(274, 85);
            button1.TabIndex = 10;
            button1.Text = "kayıt ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(45, 526);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(274, 27);
            txt_sifre.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(45, 469);
            label5.Name = "label5";
            label5.Size = new Size(62, 35);
            label5.TabIndex = 11;
            label5.Text = "şifre";
            // 
            // kayıt_ol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 706);
            Controls.Add(txt_sifre);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txt_adres);
            Controls.Add(txt_telefon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_soyisim);
            Controls.Add(label2);
            Controls.Add(txt_isim);
            Controls.Add(label1);
            Name = "kayıt_ol";
            Text = "kayıt_ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_isim;
        private TextBox txt_soyisim;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txt_telefon;
        private RichTextBox txt_adres;
        private Button button1;
        private TextBox txt_sifre;
        private Label label5;
    }
}