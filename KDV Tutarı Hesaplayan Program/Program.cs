using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDVTutariHesaplayanProgram
{
    class Program
    {
        /// <summary>
        /// Kullanıcıdan alınan para değerinin KDV'li fiyatını ve KDV tutarını hesaplayıp ekrana bastıran program
        /// </summary>
        /// <param name="kdv"></param>
        static void Main(string[] args)
        {
            
            Console.Write("Para Miktarını Giriniz:");
            double para_miktari = Convert.ToDouble(Console.ReadLine());

            if (para_miktari <0)
            {
                Console.WriteLine("Para Miktarı 0 dan küçük olamaz");
            }

            double kdv_hesapla = KDVOraniBelirle(para_miktari);
            double para_hesapla = ParaHesapla(para_miktari, kdv_hesapla);


            Console.Write("Para Miktarınız:" + para_hesapla);
            Console.Read();
        }

        static double KDVOraniBelirle(double para)
        {
            return para < 1000 ? 0.18 : 0.08;
        }

        static double ParaHesapla(double para,double kdv)
        {
            return (para * kdv) + para;
        }
    }
}
