using System;

namespace Hafta9_Temsilciler
{
    public delegate void MatematikIslemi(int a, int b);

    class MatematikIslemleri
    {
        public void Topla(int a, int b)
        {
            Console.WriteLine("Toplama Sonucu: " + (a + b));
        }

        public void Carpma(int a, int b)
        {
            Console.WriteLine("Çarpma Sonucu: " + (a * b));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MatematikIslemleri nesne = new MatematikIslemleri();

            Console.Write("Lütfen birinci sayıyı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı girin:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            MatematikIslemi temsilci = nesne.Topla;

            temsilci(sayi1, sayi2);

            temsilci += nesne.Carpma;

            Console.WriteLine("--- Çoklu Temsilci Çağrısı ---");
            temsilci(sayi1, sayi2);
            
            Console.ReadLine();
        }
    }
}