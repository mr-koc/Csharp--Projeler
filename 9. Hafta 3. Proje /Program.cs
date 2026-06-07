using System;
using System.Threading.Tasks.Dataflow;

namespace Hafta9_Olaylar
{
    public delegate void OlayYoneticisi();

    class BankaHesabı
    {
        public int Bakiye{get;set;}
        public event OlayYoneticisi BakiyeSifirlandi;
        public int paraCek(int miktar)
        {
            int kalan;

            Bakiye = Bakiye - miktar;

            if(Bakiye <= 0)
            {
                if(BakiyeSifirlandi != null)
                {
                    BakiyeSifirlandi();
                }
            }

            return Bakiye;
        }
    }
    class Program
    {

        static void HesapUyariMesaji()
        {
            Console.WriteLine("Dikkat: Hesap bakiyeniz tükenmiştir!");
        }
        static void Main(string[] args)
        {
            BankaHesabı nesne = new BankaHesabı();
            Console.WriteLine("Bakiyeniz: 5000 TL");
            nesne.Bakiye = 5000;

            nesne.BakiyeSifirlandi += HesapUyariMesaji;

            while (nesne.Bakiye > 0)
            {
                Console.WriteLine("\nNOT: Çıkmak için q yazıp Enter'a basınız.");
                Console.Write("Ne kadar TL çekmek istiyorsunuz: ");
                string giris = Console.ReadLine();

                if (giris == "q")
                {
                    break;
                }

                int x = Convert.ToInt32(giris);
                nesne.paraCek(x);
            }
            
        }
    }
}