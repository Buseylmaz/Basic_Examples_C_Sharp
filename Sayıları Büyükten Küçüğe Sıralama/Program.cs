using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilariBuyuktenKucugeSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayilar();

            Console.ReadLine();
        }

        static void Sayilar()
        {
            Console.Write("Kaç tane sayı girilecek?:");
            int kac = Convert.ToInt32(Console.ReadLine());

            int[] sayi = new int[kac];

            for (int i = 0; i < kac; i++)
            {
                Console.Write("Sayı giriniz:");
                int s = Convert.ToInt32(Console.ReadLine());
                sayi[i] = s;
            }

            Array.Sort(sayi);

            Array.Reverse(sayi);

            foreach (var sa in sayi)
            {
                Console.Write(sa+"-");
            }
            
            

        }
    }
}
