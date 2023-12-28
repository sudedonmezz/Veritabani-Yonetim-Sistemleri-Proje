namespace VerTabanProje
{
    partial class Form4
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
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            BelgeID = new TextBox();
            OgretmenNo = new TextBox();
            OgrenciNo = new TextBox();
            OkulAd = new TextBox();
            kartID = new TextBox();
            update = new Button();
            comboBox1 = new ComboBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 37);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 0;
            label1.Text = "UPDATE";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new Point(152, 231);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(96, 494);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 36;
            label8.Text = "Belge ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(77, 437);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 35;
            label7.Text = "Personal no";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(80, 380);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 34;
            label6.Text = "Ogrenci no";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(87, 325);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 33;
            label5.Text = "Okul Adi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 119);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 30;
            label2.Text = "Kart Id";
            // 
            // BelgeID
            // 
            BelgeID.Enabled = false;
            BelgeID.Location = new Point(230, 487);
            BelgeID.Name = "BelgeID";
            BelgeID.Size = new Size(125, 27);
            BelgeID.TabIndex = 29;
            // 
            // OgretmenNo
            // 
            OgretmenNo.Enabled = false;
            OgretmenNo.Location = new Point(230, 434);
            OgretmenNo.Name = "OgretmenNo";
            OgretmenNo.Size = new Size(125, 27);
            OgretmenNo.TabIndex = 28;
            // 
            // OgrenciNo
            // 
            OgrenciNo.Enabled = false;
            OgrenciNo.Location = new Point(230, 373);
            OgrenciNo.Name = "OgrenciNo";
            OgrenciNo.Size = new Size(125, 27);
            OgrenciNo.TabIndex = 27;
            // 
            // OkulAd
            // 
            OkulAd.Enabled = false;
            OkulAd.Location = new Point(230, 318);
            OkulAd.Name = "OkulAd";
            OkulAd.Size = new Size(125, 27);
            OkulAd.TabIndex = 26;
            // 
            // kartID
            // 
            kartID.Location = new Point(201, 112);
            kartID.Name = "kartID";
            kartID.Size = new Size(125, 27);
            kartID.TabIndex = 23;
            // 
            // update
            // 
            update.Enabled = false;
            update.Location = new Point(152, 539);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 38;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Engelli kart", "Ogrenci kart", "Ogretmen kart", "Sehit ailesi kart" });
            comboBox1.Location = new Point(120, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 39;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(250, 201);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 24);
            checkBox2.TabIndex = 41;
            checkBox2.Text = "Aylik";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(86, 201);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 24);
            checkBox1.TabIndex = 40;
            checkBox1.Text = "Normal";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(415, 576);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(update);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(BelgeID);
            Controls.Add(OgretmenNo);
            Controls.Add(OgrenciNo);
            Controls.Add(OkulAd);
            Controls.Add(kartID);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private TextBox BelgeID;
        private TextBox OgretmenNo;
        private TextBox OgrenciNo;
        private TextBox OkulAd;
        private TextBox kartID;
        private Button update;
        private ComboBox comboBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}