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
            components = new System.ComponentModel.Container();
            prgYukleme = new ProgressBar();
            trkHiz = new TrackBar();
            tmrYukleme = new System.Windows.Forms.Timer(components);
            lblDurum = new Label();
            btnBaslat = new Button();
            btnDurdur = new Button();
            ((System.ComponentModel.ISupportInitialize)trkHiz).BeginInit();
            SuspendLayout();
            // 
            // prgYukleme
            // 
            prgYukleme.Location = new Point(77, 67);
            prgYukleme.Name = "prgYukleme";
            prgYukleme.Size = new Size(200, 46);
            prgYukleme.TabIndex = 0;
            prgYukleme.Click += progressBar1_Click;
            // 
            // trkHiz
            // 
            trkHiz.Location = new Point(77, 159);
            trkHiz.Maximum = 500;
            trkHiz.Minimum = 10;
            trkHiz.Name = "trkHiz";
            trkHiz.Size = new Size(208, 90);
            trkHiz.TabIndex = 1;
            trkHiz.Value = 10;
            trkHiz.Scroll += tmrYukleme_Tick;
            // 
            // tmrYukleme
            // 
            tmrYukleme.Tick += tmrYukleme_Tick;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(495, 67);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(78, 32);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "label1";
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(77, 299);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(150, 46);
            btnBaslat.TabIndex = 3;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnDurdur
            // 
            btnDurdur.Location = new Point(77, 417);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(150, 46);
            btnDurdur.TabIndex = 4;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            btnDurdur.Click += btnDurdur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2051, 870);
            Controls.Add(btnDurdur);
            Controls.Add(btnBaslat);
            Controls.Add(lblDurum);
            Controls.Add(trkHiz);
            Controls.Add(prgYukleme);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trkHiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar prgYukleme;
        private TrackBar trkHiz;
        private System.Windows.Forms.Timer tmrYukleme;
        private Label lblDurum;
        private Button btnBaslat;
        private Button btnDurdur;
    }
}
