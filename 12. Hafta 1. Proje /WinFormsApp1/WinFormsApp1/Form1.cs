namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem yeniKayit = new ListViewItem(txtAd.Text);

            if(txtAd.Text == " " || txtSoyad.Text == " " || txtNumara.Text == " ")
            {
                MessageBox.Show("Lütfen değeri veya değerleri giriniz.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            yeniKayit.SubItems.Add(txtSoyad.Text);
            yeniKayit.SubItems.Add(txtNumara.Text);

            lvOgrenciler.Items.Add(yeniKayit);

            txtNumara.Clear();
            txtAd.Clear();
            txtSoyad.Clear();

            txtAd.Focus();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvOgrenciler.SelectedItems.Count > 0)
            {
                lvOgrenciler.Items.Remove(lvOgrenciler.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için listeden bir öğrenci seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
