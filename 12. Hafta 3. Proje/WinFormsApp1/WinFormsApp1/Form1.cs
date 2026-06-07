namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            prgYukleme.Value = 0;
            tmrYukleme.Start();
        }

        private void trkHiz_Scroll(object sender, EventArgs e)
        {
            tmrYukleme.Interval = trkHiz.Value;
            lblDurum.Text = trkHiz.Value.ToString();
            lblDurum.Text = "Yükleniyor...";
        }

        private void tmrYukleme_Tick(object sender, EventArgs e)
        {
            prgYukleme.Value += 1;

            if (prgYukleme.Value == 100)
            {
                tmrYukleme.Stop();
                MessageBox.Show("Yükleme tamamlandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            tmrYukleme.Stop();
            lblDurum.Text = "Duraklatıldı";
        }
    }
}
