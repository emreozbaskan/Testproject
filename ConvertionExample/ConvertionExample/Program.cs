using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan kullanıcıdan bir sayı alıp bu sayının karesini hesaplayan prog yazınız.
            Console.Write("Lütfen bir sayı giriniz.");
            int Sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = Sayi * Sayi;
            Console.WriteLine("Sonuç" + sonuc);
            Console.ReadKey();
        }
    }
}
