using System;
using System.IO; 

namespace Hafta10_KlasorRapor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Klasör yolunu giriniz: ");
            string yol = Console.ReadLine();

            DirectoryInfo klasor = new DirectoryInfo(yol);

            if (klasor.Exists == false)
            {
                Console.WriteLine("Hata: Klasör bulunamadı!");
            }
            else
            {
                FileInfo[] dosyalar = klasor.GetFiles();

                int toplamDosya = 0;
                long toplamBoyut = 0; 

                foreach (FileInfo dosya in dosyalar)
{
    long boyutKB = dosya.Length / 1024;
    
    Console.WriteLine("Dosya Adı: " + dosya.Name + "\nUzantısı: " + dosya.Extension + "\nBoyutu (KB): " + boyutKB + "\nOluşturulma Tarihi: " + dosya.CreationTime + "\n--------------------------------");

    toplamDosya++;
    toplamBoyut += boyutKB;
}

Console.WriteLine("ÖZET BİLGİLER\nToplam Dosya Sayısı: " + toplamDosya + "\nToplam Boyut (KB): " + toplamBoyut);
            }

            Console.ReadLine();
        }
    }
}
