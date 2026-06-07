namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioCay = new RadioButton();
            radioKahve = new RadioButton();
            radioLimonata = new RadioButton();
            groupBox2 = new GroupBox();
            checkSut = new CheckBox();
            checkSeker = new CheckBox();
            checkBuz = new CheckBox();
            comboUcluDeger = new ComboBox();
            btnSiparis = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioLimonata);
            groupBox1.Controls.Add(radioCay);
            groupBox1.Controls.Add(radioKahve);
            groupBox1.Location = new Point(49, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "İçecekler";
            // 
            // radioCay
            // 
            radioCay.AutoSize = true;
            radioCay.Location = new Point(16, 38);
            radioCay.Name = "radioCay";
            radioCay.Size = new Size(84, 36);
            radioCay.TabIndex = 1;
            radioCay.TabStop = true;
            radioCay.Text = "Çay";
            radioCay.UseVisualStyleBackColor = true;
            // 
            // radioKahve
            // 
            radioKahve.AutoSize = true;
            radioKahve.Location = new Point(16, 89);
            radioKahve.Name = "radioKahve";
            radioKahve.Size = new Size(110, 36);
            radioKahve.TabIndex = 2;
            radioKahve.TabStop = true;
            radioKahve.Text = "Kahve";
            radioKahve.UseVisualStyleBackColor = true;
            // 
            // radioLimonata
            // 
            radioLimonata.AutoSize = true;
            radioLimonata.Location = new Point(16, 146);
            radioLimonata.Name = "radioLimonata";
            radioLimonata.Size = new Size(143, 36);
            radioLimonata.TabIndex = 3;
            radioLimonata.TabStop = true;
            radioLimonata.Text = "Limonata";
            radioLimonata.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboUcluDeger);
            groupBox2.Controls.Add(checkBuz);
            groupBox2.Controls.Add(checkSeker);
            groupBox2.Controls.Add(checkSut);
            groupBox2.Location = new Point(49, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 317);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ekstralar";
            // 
            // checkSut
            // 
            checkSut.AutoSize = true;
            checkSut.Location = new Point(6, 51);
            checkSut.Name = "checkSut";
            checkSut.Size = new Size(81, 36);
            checkSut.TabIndex = 0;
            checkSut.Text = "Süt";
            checkSut.UseVisualStyleBackColor = true;
            // 
            // checkSeker
            // 
            checkSeker.AutoSize = true;
            checkSeker.Location = new Point(6, 93);
            checkSeker.Name = "checkSeker";
            checkSeker.Size = new Size(105, 36);
            checkSeker.TabIndex = 1;
            checkSeker.Text = "Şeker";
            checkSeker.UseVisualStyleBackColor = true;
            // 
            // checkBuz
            // 
            checkBuz.AutoSize = true;
            checkBuz.Location = new Point(6, 135);
            checkBuz.Name = "checkBuz";
            checkBuz.Size = new Size(85, 36);
            checkBuz.TabIndex = 2;
            checkBuz.Text = "Buz";
            checkBuz.UseVisualStyleBackColor = true;
            // 
            // comboUcluDeger
            // 
            comboUcluDeger.FormattingEnabled = true;
            comboUcluDeger.Items.AddRange(new object[] { "Küçük Boy", "Orta Boy", "Büyük Boy" });
            comboUcluDeger.Location = new Point(6, 183);
            comboUcluDeger.Name = "comboUcluDeger";
            comboUcluDeger.Size = new Size(242, 40);
            comboUcluDeger.TabIndex = 3;
            comboUcluDeger.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSiparis
            // 
            btnSiparis.Location = new Point(55, 548);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(170, 46);
            btnSiparis.TabIndex = 5;
            btnSiparis.Text = "Sipariş Özeti";
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 824);
            Controls.Add(btnSiparis);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioLimonata;
        private RadioButton radioCay;
        private RadioButton radioKahve;
        private GroupBox groupBox2;
        private ComboBox comboUcluDeger;
        private CheckBox checkBuz;
        private CheckBox checkSeker;
        private CheckBox checkSut;
        private Button btnSiparis;
    }
}
