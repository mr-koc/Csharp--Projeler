namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (comboUcluDeger.Items.Count > 0)
            {
                comboUcluDeger.SelectedIndex = 0;
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            string seciliIcecek = "";

            if (radioCay.Checked == true)
            {
                seciliIcecek = "Çay";
            }
            else if (radioKahve.Checked == true)
            {
                seciliIcecek = "Kahve";
            }
            else if (radioLimonata.Checked == true)
            {
                seciliIcecek = "Limonata";
            }

            if (seciliIcecek == "")
            {
                MessageBox.Show("Lütfen bir tane içecek seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (comboUcluDeger.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir tane boy seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string seciliBoy = comboUcluDeger.SelectedItem.ToString();

            string extralar = "";

            if (checkSut.Checked == true)
            {
                extralar = extralar + "Süt ";
            }
            if (checkBuz.Checked == true) 
            {
                extralar = extralar + "Buz ";
            }

            if (checkSeker.Checked == true)
            {
                extralar = extralar + "Seker";
            }

            if (extralar == "")
            {
                extralar = "Yok";
            }

            string mesaj = "İçecek: " + seciliIcecek + "\nBoy: " + seciliBoy + "\nEkstralar: " + extralar;
            MessageBox.Show(mesaj, "Sipariş Özeti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}