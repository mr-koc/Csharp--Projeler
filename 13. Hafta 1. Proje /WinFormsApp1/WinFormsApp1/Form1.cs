using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            // Adresi doğrudan string içine yazıp TextBox'a aktarıyoruz.
            string baglantiAdresi = @"Server=.\SQLEXPRESS;Database=okul;Integrated Security=true;";
            txtConnStr.Text = baglantiAdresi;

            SqlConnection baglanti = new SqlConnection(baglantiAdresi);

            try
            {
                baglanti.Open();
                lblDurum.Text = "Bağlantı Durumu: " + baglanti.State.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDurum.Text = "Bağlantı Durumu: Başarısız";
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void txtConnStr_TextChanged(object sender, EventArgs e)
        {
            txtConnStr.Text = @"Server=(localdb)\MSSQLLocalDB;Database=Okul;Integrated Security=true;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
