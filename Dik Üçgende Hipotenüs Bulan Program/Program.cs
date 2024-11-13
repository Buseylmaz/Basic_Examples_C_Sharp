using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikUcgendeHipotenusBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci kenarı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci kenarı giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü kenarı giriniz: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Hipotenüs(a, b);
            UcgenAlan(a,b,c);

            Console.Read();
        }

        static int Hipotenüs(int kenar1,int kenar2)
        {
            int kenar3= (kenar1 * kenar1) + (kenar2 * kenar2);
            double a= Math.Sqrt(kenar3);
            Console.WriteLine("Hipotenüs kenar:" + a);
            return kenar3; 
        }

        static int UcgenAlan(int kenar1,int kenar2,int kenar3)
        {
            int u = (kenar1 + kenar2 + kenar3) / 2;
            int alan=(u* (u - kenar1)*(u - kenar2) *(u - kenar3));

            Console.WriteLine("Üçgenin alanı:" + alan);
            return alan;

            
        }
    }
}
