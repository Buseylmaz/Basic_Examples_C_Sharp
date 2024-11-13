using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksimetreProgrami
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = Yol();
            YolUcreti(y);

            Console.Read();

        }

        static double Yol()
        {
            Console.Write("Kaç km yol gittiniz?:");
            double yol_uzunlugu = Convert.ToDouble(Console.ReadLine());

            return yol_uzunlugu;
        }
        static double YolUcreti(double yol_uzunlugu)
        {
            int baslangic = 10;
            int min_ucret = 20;
            double km_ucret = 2.20;

            double tutar = (yol_uzunlugu * km_ucret) + baslangic;

            if (tutar < min_ucret)
            {
                tutar = min_ucret;
            }
            
            Console.Write("Yol ücretiniz:" + tutar);


            return tutar;

            
        }
    }
}
