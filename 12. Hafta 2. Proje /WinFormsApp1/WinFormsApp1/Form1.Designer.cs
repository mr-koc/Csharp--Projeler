namespace WinFormsApp1
{
    partial class tabControl1
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
            lblSonucCarpma = new TabControl();
            tabPage1 = new TabPage();
            lblSonucToplama = new Label();
            btnTop = new Button();
            SayiTop1 = new TextBox();
            SayiTop2 = new TextBox();
            tabPage2 = new TabPage();
            lblSonucCikarma = new Label();
            btnCik = new Button();
            SayiCik1 = new TextBox();
            SayiCik2 = new TextBox();
            tabContr = new TabPage();
            label2 = new Label();
            btnCarp = new Button();
            SayiCarp1 = new TextBox();
            SayiCarp2 = new TextBox();
            lblSonucCarpma.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabContr.SuspendLayout();
            SuspendLayout();
            // 
            // lblSonucCarpma
            // 
            lblSonucCarpma.Controls.Add(tabPage1);
            lblSonucCarpma.Controls.Add(tabPage2);
            lblSonucCarpma.Controls.Add(tabContr);
            lblSonucCarpma.Location = new Point(31, 33);
            lblSonucCarpma.Name = "lblSonucCarpma";
            lblSonucCarpma.SelectedIndex = 0;
            lblSonucCarpma.Size = new Size(783, 380);
            lblSonucCarpma.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblSonucToplama);
            tabPage1.Controls.Add(btnTop);
            tabPage1.Controls.Add(SayiTop1);
            tabPage1.Controls.Add(SayiTop2);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(767, 326);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Toplama";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSonucToplama
            // 
            lblSonucToplama.AutoSize = true;
            lblSonucToplama.Location = new Point(499, 152);
            lblSonucToplama.Name = "lblSonucToplama";
            lblSonucToplama.Size = new Size(85, 32);
            lblSonucToplama.TabIndex = 13;
            lblSonucToplama.Text = "Sonuç:";
            // 
            // btnTop
            // 
            btnTop.Location = new Point(228, 182);
            btnTop.Name = "btnTop";
            btnTop.Size = new Size(150, 46);
            btnTop.TabIndex = 12;
            btnTop.Text = "Hesapla";
            btnTop.UseVisualStyleBackColor = true;
            btnTop.Click += btnTop_Click;
            // 
            // SayiTop1
            // 
            SayiTop1.Location = new Point(182, 99);
            SayiTop1.Name = "SayiTop1";
            SayiTop1.Size = new Size(99, 39);
            SayiTop1.TabIndex = 10;
            // 
            // SayiTop2
            // 
            SayiTop2.Location = new Point(327, 99);
            SayiTop2.Name = "SayiTop2";
            SayiTop2.Size = new Size(99, 39);
            SayiTop2.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblSonucCikarma);
            tabPage2.Controls.Add(btnCik);
            tabPage2.Controls.Add(SayiCik1);
            tabPage2.Controls.Add(SayiCik2);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(767, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Çıkarma";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSonucCikarma
            // 
            lblSonucCikarma.AutoSize = true;
            lblSonucCikarma.Location = new Point(499, 152);
            lblSonucCikarma.Name = "lblSonucCikarma";
            lblSonucCikarma.Size = new Size(85, 32);
            lblSonucCikarma.TabIndex = 13;
            lblSonucCikarma.Text = "Sonuç:";
            // 
            // btnCik
            // 
            btnCik.Location = new Point(228, 182);
            btnCik.Name = "btnCik";
            btnCik.Size = new Size(150, 46);
            btnCik.TabIndex = 12;
            btnCik.Text = "Hesapla";
            btnCik.UseVisualStyleBackColor = true;
            btnCik.Click += btnCik_Click;
            // 
            // SayiCik1
            // 
            SayiCik1.Location = new Point(182, 99);
            SayiCik1.Name = "SayiCik1";
            SayiCik1.Size = new Size(99, 39);
            SayiCik1.TabIndex = 10;
            // 
            // SayiCik2
            // 
            SayiCik2.Location = new Point(327, 99);
            SayiCik2.Name = "SayiCik2";
            SayiCik2.Size = new Size(99, 39);
            SayiCik2.TabIndex = 11;
            // 
            // tabContr
            // 
            tabContr.Controls.Add(label2);
            tabContr.Controls.Add(btnCarp);
            tabContr.Controls.Add(SayiCarp1);
            tabContr.Controls.Add(SayiCarp2);
            tabContr.Location = new Point(8, 46);
            tabContr.Name = "tabContr";
            tabContr.Padding = new Padding(3);
            tabContr.Size = new Size(767, 326);
            tabContr.TabIndex = 2;
            tabContr.Text = "Çarpma";
            tabContr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 152);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 13;
            label2.Text = "Sonuç:";
            // 
            // btnCarp
            // 
            btnCarp.Location = new Point(228, 182);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(150, 46);
            btnCarp.TabIndex = 12;
            btnCarp.Text = "Hesapla";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // SayiCarp1
            // 
            SayiCarp1.Location = new Point(182, 99);
            SayiCarp1.Name = "SayiCarp1";
            SayiCarp1.Size = new Size(99, 39);
            SayiCarp1.TabIndex = 10;
            // 
            // SayiCarp2
            // 
            SayiCarp2.Location = new Point(327, 99);
            SayiCarp2.Name = "SayiCarp2";
            SayiCarp2.Size = new Size(99, 39);
            SayiCarp2.TabIndex = 11;
            // 
            // tabControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 644);
            Controls.Add(lblSonucCarpma);
            Name = "tabControl1";
            Text = "Form1";
            lblSonucCarpma.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabContr.ResumeLayout(false);
            tabContr.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl lblSonucCarpma;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabContr;
        private Label lblSonucToplama;
        private Button btnTop;
        private TextBox SayiTop1;
        private TextBox SayiTop2;
        private Label lblSonucCikarma;
        private Button btnCik;
        private TextBox SayiCik1;
        private TextBox SayiCik2;
        private Label label2;
        private Button btnCarp;
        private TextBox SayiCarp1;
        private TextBox SayiCarp2;
    }
}
