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
            lstOgrenciler = new ListBox();
            lblToplam = new Label();
            btnYukle = new Button();
            SuspendLayout();
            // 
            // lstOgrenciler
            // 
            lstOgrenciler.FormattingEnabled = true;
            lstOgrenciler.Location = new Point(28, 29);
            lstOgrenciler.Name = "lstOgrenciler";
            lstOgrenciler.Size = new Size(409, 260);
            lstOgrenciler.TabIndex = 0;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(498, 142);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(92, 32);
            lblToplam.TabIndex = 1;
            lblToplam.Text = "Toplam";
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(141, 331);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(150, 46);
            btnYukle.TabIndex = 2;
            btnYukle.Text = "Yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 626);
            Controls.Add(btnYukle);
            Controls.Add(lblToplam);
            Controls.Add(lstOgrenciler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOgrenciler;
        private Label lblToplam;
        private Button btnYukle;
    }
}
