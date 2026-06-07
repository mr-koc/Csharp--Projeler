using System;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    string baglantiDizesi = @"Data Source=.;Initial Catalog=Okul;Integrated Security=True";

    public Form1()
    {
        InitializeComponent();
    }

    private void btnYukle_Click(object sender, EventArgs e)
    {
        lstOgrenciler.Items.Clear();

        using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
        {
            try
            {
                baglanti.Open();

                string sorgu1 = "SELECT COUNT(*) FROM Ogrenci";
                SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);

                int ogrenciSayisi = (int)komut1.ExecuteScalar();

                lblToplam.Text = "Toplam " + ogrenciSayisi + " öğrenci";

                string sorgu2 = "SELECT No, Ad, Soyad, Bolum FROM Ogrenci ORDER BY No";
                SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);

                SqlDataReader rdr = komut2.ExecuteReader();

                while (rdr.Read())
                {
                    string no = rdr["No"].ToString();
                    string ad = rdr["Ad"].ToString();
                    string soyad = rdr["Soyad"].ToString();
                    string bolum = rdr["Bolum"].ToString();

                    string formatliSatir = no + " - " + ad + " " + soyad + " (" + bolum + ")";

                    lstOgrenciler.Items.Add(formatliSatir);
                }

                rdr.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu:\n" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}