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
            lvOgrenciler = new ListView();
            jdbvkabdk = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // lvOgrenciler
            // 
            lvOgrenciler.Columns.AddRange(new ColumnHeader[] { jdbvkabdk, columnHeader1, columnHeader2 });
            lvOgrenciler.FullRowSelect = true;
            lvOgrenciler.GridLines = true;
            lvOgrenciler.Location = new Point(74, 33);
            lvOgrenciler.Name = "lvOgrenciler";
            lvOgrenciler.Size = new Size(563, 194);
            lvOgrenciler.TabIndex = 0;
            lvOgrenciler.UseCompatibleStateImageBehavior = false;
            lvOgrenciler.View = View.Details;
            // 
            // jdbvkabdk
            // 
            jdbvkabdk.Text = "Ad:";
            jdbvkabdk.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Soyad:";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numara:";
            columnHeader2.Width = 120;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(662, 33);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 39);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(662, 97);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 39);
            txtSoyad.TabIndex = 2;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(662, 172);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(200, 39);
            txtNumara.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(74, 271);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(150, 46);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(447, 271);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 46);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 676);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lvOgrenciler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvOgrenciler;
        private ColumnHeader jdbvkabdk;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private Button btnEkle;
        private Button btnSil;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
