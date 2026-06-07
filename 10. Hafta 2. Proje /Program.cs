using System;
using System.IO;

namespace Hafta10_AkimMetin
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamWriter yazma = new StreamWriter("ogrenciler.txt"))

            for(int j = 1; j<=30; j++)
            {
                Console.Write(j+". öğrencinin adını giriniz: ");
                string giris = Console.ReadLine();

                if(giris == " ")
                {
                    break;
                }
                yazma.WriteLine(giris);
            }

            using(StreamReader okuma = new StreamReader("ogrenciler.txt"))
            {
                string satir;
                int satirNo = 1;
                while((satir = okuma.ReadLine()) != null)
                {
                    Console.WriteLine(satirNo + satir);
                    satirNo++;
                }
            }


        }
    }
}