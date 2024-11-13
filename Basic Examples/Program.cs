using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Not();

            Console.Read();
        }


        /// <summary>
        /// Kullanıcıdan almış oldugu bilgilerle not ortalamasını çıkaran uygulama
        /// </summary>
        static void Not()
        {
            try
            {
                int toplam = 0;
                Console.Write("Lütfen toplamda kaç tane dersiniz varsa sayısını giriniz:");

                int ders = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < ders; i++)
                {
                    Console.Write((i + 1) + ". dersi giriniz:");
                    int notlar = Convert.ToInt32(Console.ReadLine());
                    toplam += notlar;
                }

                int ortalama = toplam / ders;

                string sonuc=(ortalama > 60) ? "Sınıfı Geçtin" : "Sınıfta Kaldın";

                Console.Write("Sonucunuz:" + sonuc);
            }
            catch (Exception)
            {
                Console.WriteLine("HATA");
            }

            
        }
    }
}
