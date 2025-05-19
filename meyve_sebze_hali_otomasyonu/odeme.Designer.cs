namespace meyve_sebze_hali_otomasyonu
{
    partial class odeme
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
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(73, 123);
            maskedTextBox1.Mask = "0000-0000-0000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(227, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(73, 206);
            maskedTextBox2.Mask = "00/00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(69, 27);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(228, 206);
            maskedTextBox3.Mask = "000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(69, 27);
            maskedTextBox3.TabIndex = 2;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(73, 58);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(227, 27);
            maskedTextBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 24);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 4;
            label1.Text = "kart sahibinin ismi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 92);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 5;
            label2.Text = "kart numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 175);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 6;
            label3.Text = "tarih";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(228, 175);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 7;
            label4.Text = "CVC";
            // 
            // button1
            // 
            button1.Location = new Point(76, 306);
            button1.Name = "button1";
            button1.Size = new Size(224, 54);
            button1.TabIndex = 8;
            button1.Text = "öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(maskedTextBox4);
            panel1.Location = new Point(204, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 380);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(135, 253);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 10;
            label5.Text = "ücret : ";
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "odeme";
            Text = "odeme";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Panel panel1;
        private Label label5;
    }
}