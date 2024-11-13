using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_Kasa_Programı
{
    class Program
    {
        enum Meyve
        {
            ARMUT = 214,  // Fiyatı 2.14 TL, ancak kuruşu tam sayı olarak saklıyoruz
            ELMA = 367,   
            DOMATES = 111, 
            MUZ = 95,    
            PATLICAN = 500 
        }

        static void Main(string[] args)
        {
            double toplamTutar = 0.0;

            // Kullanıcıdan her meyve için kilogram değerlerini alıyoruz
            foreach (Meyve meyveler in Enum.GetValues(typeof(Meyve)))
            {
                Console.WriteLine($"{meyveler} kaç kg?");
                double kilogram = Convert.ToDouble(Console.ReadLine());

                double meyveFiyati = (int)meyveler / 100.0;// Meyve fiyatını kuruş olarak alıyoruz ve 100'e bölerek TL'ye çeviriyoruz
                toplamTutar += meyveFiyati * kilogram;
            }

            Console.WriteLine($"Toplam tutar: {toplamTutar:F2} TL");

            Console.ReadLine();
        }
    }
}
