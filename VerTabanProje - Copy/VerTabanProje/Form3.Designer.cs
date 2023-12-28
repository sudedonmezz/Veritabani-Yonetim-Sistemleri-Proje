namespace VerTabanProje
{
    partial class Form3
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
            comboBox1 = new ComboBox();
            kartID = new TextBox();
            TC = new TextBox();
            OkulAd = new TextBox();
            OgrenciNo = new TextBox();
            OgretmenNo = new TextBox();
            BelgeID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ok = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            RenkTx = new TextBox();
            UcretTx = new TextBox();
            label9 = new Label();
            Ucret = new Label();
            INSERT = new Button();
            DogumT = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 26);
            label1.Name = "label1";
            label1.Size = new Size(87, 31);
            label1.TabIndex = 0;
            label1.Text = "INSERT";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "60 yas ustu kart", "65 yas ustu kart", "Anonim kart", "Engelli kart", "Ogrenci kart", "Ogretmen kart", "Sehit ailesi kart" });
            comboBox1.Location = new Point(123, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // kartID
            // 
            kartID.Enabled = false;
            kartID.Location = new Point(234, 167);
            kartID.Name = "kartID";
            kartID.Size = new Size(125, 27);
            kartID.TabIndex = 2;
            // 
            // TC
            // 
            TC.Enabled = false;
            TC.Location = new Point(234, 213);
            TC.Name = "TC";
            TC.Size = new Size(125, 27);
            TC.TabIndex = 3;
            // 
            // OkulAd
            // 
            OkulAd.Enabled = false;
            OkulAd.Location = new Point(234, 328);
            OkulAd.Name = "OkulAd";
            OkulAd.Size = new Size(125, 27);
            OkulAd.TabIndex = 5;
            // 
            // OgrenciNo
            // 
            OgrenciNo.Enabled = false;
            OgrenciNo.Location = new Point(234, 383);
            OgrenciNo.Name = "OgrenciNo";
            OgrenciNo.Size = new Size(125, 27);
            OgrenciNo.TabIndex = 6;
            // 
            // OgretmenNo
            // 
            OgretmenNo.Enabled = false;
            OgretmenNo.Location = new Point(234, 444);
            OgretmenNo.Name = "OgretmenNo";
            OgretmenNo.Size = new Size(125, 27);
            OgretmenNo.TabIndex = 7;
            // 
            // BelgeID
            // 
            BelgeID.Enabled = false;
            BelgeID.Location = new Point(234, 497);
            BelgeID.Name = "BelgeID";
            BelgeID.Size = new Size(125, 27);
            BelgeID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(96, 174);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 9;
            label2.Text = "Kart Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(100, 220);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "TC No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(68, 276);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 11;
            label4.Text = "Dogum Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(91, 335);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 12;
            label5.Text = "Okul Adi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(84, 390);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 13;
            label6.Text = "Ogrenci no";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(81, 447);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 14;
            label7.Text = "Personal no";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(100, 504);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 15;
            label8.Text = "Belge ID";
            // 
            // ok
            // 
            ok.Location = new Point(337, 125);
            ok.Name = "ok";
            ok.Size = new Size(54, 29);
            ok.TabIndex = 16;
            ok.Text = "OK";
            ok.UseVisualStyleBackColor = true;
            ok.Click += Insert_ok_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(96, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Normal";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(258, 130);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 24);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Aylik";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // RenkTx
            // 
            RenkTx.Enabled = false;
            RenkTx.Location = new Point(234, 550);
            RenkTx.Name = "RenkTx";
            RenkTx.Size = new Size(125, 27);
            RenkTx.TabIndex = 19;
            // 
            // UcretTx
            // 
            UcretTx.Enabled = false;
            UcretTx.Location = new Point(234, 600);
            UcretTx.Name = "UcretTx";
            UcretTx.Size = new Size(125, 27);
            UcretTx.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Location = new Point(100, 556);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 21;
            label9.Text = "RENK";
            // 
            // Ucret
            // 
            Ucret.AutoSize = true;
            Ucret.Enabled = false;
            Ucret.Location = new Point(100, 603);
            Ucret.Name = "Ucret";
            Ucret.Size = new Size(53, 20);
            Ucret.TabIndex = 22;
            Ucret.Text = "UCRET";
            // 
            // INSERT
            // 
            INSERT.Enabled = false;
            INSERT.Location = new Point(160, 646);
            INSERT.Name = "INSERT";
            INSERT.Size = new Size(94, 29);
            INSERT.TabIndex = 23;
            INSERT.Text = "INSERT";
            INSERT.UseVisualStyleBackColor = true;
            INSERT.Click += INSERT_Click;
            // 
            // DogumT
            // 
            DogumT.Enabled = false;
            DogumT.Location = new Point(234, 273);
            DogumT.Name = "DogumT";
            DogumT.Size = new Size(125, 27);
            DogumT.TabIndex = 25;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(443, 687);
            Controls.Add(DogumT);
            Controls.Add(INSERT);
            Controls.Add(Ucret);
            Controls.Add(label9);
            Controls.Add(UcretTx);
            Controls.Add(RenkTx);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(ok);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BelgeID);
            Controls.Add(OgretmenNo);
            Controls.Add(OgrenciNo);
            Controls.Add(OkulAd);
            Controls.Add(TC);
            Controls.Add(kartID);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private TextBox kartID;
        private TextBox TC;
        private TextBox OkulAd;
        private TextBox OgrenciNo;
        private TextBox OgretmenNo;
        private TextBox BelgeID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button ok;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox RenkTx;
        private TextBox UcretTx;
        private Label label9;
        private Label Ucret;
        private Button INSERT;
        private TextBox DogumT;
    }
}