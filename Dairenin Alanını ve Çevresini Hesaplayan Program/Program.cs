using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaireninAlanÇevresiniHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Lütfen dairenin yarı çapanı yazınız:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen dairenin merkez açısını giriniz:");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Daire Alanı:" + DaireAlan(pi, r));
            Console.WriteLine("Daire Cevresi:" + DaireCevre(pi, r));
            Console.Write("Çeyrek Daire Alanı:" + CeyrekDaireAlani(pi, r, a));

            Console.Read();

        }

        static double DaireAlan(double pi,int r)
        {
            return  pi * Math.Pow(r, 2);
        }

        static double DaireCevre(double pi, int r)
        {
            return 2 * pi * r;
        }

        static double CeyrekDaireAlani(double pi,int r,double a)
        {
            return (DaireAlan(pi, r) * a) / 360;
        }
    }
}
