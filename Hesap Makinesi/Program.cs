using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç tane sayı giriceksiniz: ");
            int kac_sayi = Convert.ToInt32(Console.ReadLine());


            int[] sayilar = new int[kac_sayi];

            for (int i = 0; i < kac_sayi; i++)
            {

                Console.Write($"{i+1} .sayı: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }

            //Console.Write("Dizi eleman sayısı:" + sayilar.Length);

            Console.Write("Yapacagınız işlem:(+,-,*,/) ");
            char islem = Convert.ToChar(Console.ReadLine());
            

            switch (islem)
            {
                case '+':
                    Toplama(sayilar);
                    break;
                case '-':
                    Cikartma(sayilar);
                    break;
                case '*':
                    Carpma(sayilar);
                    break;
                case '/':
                    Bolme(sayilar);
                    break;
                default:
                    Console.Write("HATALI İŞLEM GİRİŞİ");
                    break;
            }

            Console.Read();
        }

        static int Toplama(int[] sayi)
        {
            int toplam = 0;
            for (int i = 0; i < sayi.Length; i++)
                toplam += sayi[i];
            Console.WriteLine("Toplama İşlemi:" + toplam);

            return toplam;

        }

        static int Cikartma(int[] sayi)
        {
            int cikarma = 0;
            for (int i = 0; i < sayi.Length; i++)
                cikarma -= sayi[i];
            Console.WriteLine("Çıkarma İşlemi:" + cikarma);

            return cikarma;

        }

        static int Carpma(int[] sayi)
        {
            int carpma = 1;
            for (int i = 0; i < sayi.Length; i++)
                carpma *= sayi[i];
            Console.WriteLine("Çarpma İşlemi:" + carpma);

            return carpma;

        }

        static int Bolme(int[] sayi)
        {
            double bolme = sayi[0];

            for (int i = 1; i < sayi.Length; i++)
            {
                if (sayi[i] != 0)
                {
                    bolme /= sayi[i];
                }
                else
                {
                    Console.WriteLine("Hata: Sıfıra bölme yapılamaz.");
                    return 0;
                }
            }
         
            Console.WriteLine("Bölme İşlemi:" + bolme);
            return (int)bolme;

        }
    }
}
