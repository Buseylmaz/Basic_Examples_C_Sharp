using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifre_Dogrulugu
{
    class Program
    {
        static void Main(string[] args)
        {
            string sifre = "sifre123456";

            Console.Write("Şifrenizi girin lütfen:");
            string sif = Console.ReadLine();

            if (sifre == sif)
            {
                Console.Write("Şifre Dogru.");
            }

            else if (sifre != sif)
            {
                Console.WriteLine("Şifre Yanlış!!!! Tekrar denemek istermisiniz?(E/H):");

                char secim = Convert.ToChar(Console.ReadLine());

                switch (secim)
                {
                    case 'E':
                        Console.WriteLine("Şifrenizi girin lütfen:");
                        string sif1 = Console.ReadLine();
                        if (sifre == sif1)
                        {
                            Console.WriteLine("Şifre Dogru.");
                        }
                        else
                        {
                            Console.WriteLine("Şifre Yanlış!!!! Yeni şifre belirleyin!!!");
                            Console.Write("Yeni şifrenizi girin:");
                            string yeni_sifre = Console.ReadLine();
                            sifre = yeni_sifre;
                            Console.WriteLine("Şifre başarılı bir şekilde güncellendi." + sifre);

                        }
                        break;
                    case 'H':
                        break;
                    default:
                        break;
                }
            }


            Console.Read();
        }
    }
}
