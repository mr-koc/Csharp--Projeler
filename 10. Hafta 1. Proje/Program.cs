using System;
using System.IO;

namespace Hafta10_DizinDosya
{
    class Program
    {
        static void Main(string[] args)
        {
            string klasoradi = "LAB10_CALISMA"; 
            string dosyaadi = "notlar.txt";
            string dosyaadi2 = "eski_notlar.txt";

            if(!Directory.Exists(klasoradi))
            {
                Directory.CreateDirectory(klasoradi);
            }else
            {
                Console.WriteLine("Bu klasör zaten var!");
            }

            FileStream fs = File.Create(klasoradi + "/" + dosyaadi);
            fs.Close();

            Console.WriteLine("\nKopyalanmış dosya: \n");
            File.Copy(klasoradi + "/" + dosyaadi, klasoradi + "/notlar_kopya.txt");

            Console.WriteLine("\nTaşınmış/Adı Değişmiş dosya: \n");
            File.Move(klasoradi + "/notlar_kopya.txt", klasoradi + "/" + dosyaadi2);

            Console.WriteLine("\n--Sırasıyla Tüm Dosyalar--\n");
            string[] tumdosyalar = Directory.GetFiles(klasoradi);

            Console.WriteLine("Dosya Yolu\t\t\t\tDosya Adı");
            Console.WriteLine("------------------------------------------------------------------");
            
            foreach(string dosya in tumdosyalar)
            {
                Console.WriteLine(dosya + "\t\t" + Path.GetFileName(dosya));
            }
        }
    }
}