namespace WinFormsApp1
{
    public partial class tabControl1 : Form
    {
        public tabControl1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasligiGuncelle();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BasligiGuncelle();
        }

        private void BasligiGuncelle()
        {
            this.Text = "Hesap Makinesi — " + lblSonucCarpma.SelectedTab.Text;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {

            if (int.TryParse(SayiTop1.Text, out int sayi1) && int.TryParse(SayiTop2.Text, out int sayi2))
            {
                lblSonucToplama.Text = "Sonuç: " + (sayi1 + sayi2).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli Sayılar giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SayiCik1.Text, out int sayii1) && int.TryParse(SayiCik2.Text, out int sayii2))
            {
                lblSonucCikarma.Text = "Sonuç: " + (sayii1 - sayii2).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli Sayılar giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SayiCarp1.Text, out int sayiii1) && int.TryParse(SayiCarp2.Text, out int sayiii2))
            {
                label2.Text = "Sonuç: " + (sayiii1 * sayiii2).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli Sayılar giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
