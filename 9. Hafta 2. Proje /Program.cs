using System;

namespace Hafta9_IsımsızMetotlar
{
    public delegate void HesaplamaIslemi(double a, double b);

    class Hesaplama
    {
        public void ortalama(double a, double b)
        {
            Console.WriteLine("Sayıların Ortalaması: "+ ((a+b)/2));
        }

         public void toplamı(double a, double b)
        {
            Console.WriteLine("Sayıların Toplamı: "+ ((a+b)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen birinci sayıyı girin: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı girin: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Hesaplama nesne = new Hesaplama();
            HesaplamaIslemi temsilci = nesne.ortalama;
            temsilci += nesne.toplamı;
            temsilci(x,y);


            

            

        }
    }
}