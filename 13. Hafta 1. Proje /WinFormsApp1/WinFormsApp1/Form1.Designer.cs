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
            btnBaglan = new Button();
            lblDurum = new Label();
            txtConnStr = new TextBox();
            SuspendLayout();
            // 
            // btnBaglan
            // 
            btnBaglan.Location = new Point(417, 297);
            btnBaglan.Name = "btnBaglan";
            btnBaglan.Size = new Size(150, 46);
            btnBaglan.TabIndex = 0;
            btnBaglan.Text = "Bağlan";
            btnBaglan.UseVisualStyleBackColor = true;
            btnBaglan.Click += btnBaglan_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(732, 266);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(88, 32);
            lblDurum.TabIndex = 1;
            lblDurum.Text = "Durum";
            // 
            // txtConnStr
            // 
            txtConnStr.Location = new Point(394, 214);
            txtConnStr.Multiline = true;
            txtConnStr.Name = "txtConnStr";
            txtConnStr.ReadOnly = true;
            txtConnStr.Size = new Size(200, 39);
            txtConnStr.TabIndex = 2;
            txtConnStr.TextChanged += txtConnStr_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 737);
            Controls.Add(txtConnStr);
            Controls.Add(lblDurum);
            Controls.Add(btnBaglan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaglan;
        private Label lblDurum;
        private TextBox txtConnStr;
    }
}
