using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 5; i++)

            {

                for (int j = 5; j > i; j--)

                {

                    Console.Write("*");

                }

                Console.Write("\n");

            }

            int sayi1, sayi2;
            string secim;
            Console.Write("1.sayıyı giriniz:");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.sayıyı giriniz:");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Listeden bir işlem seçiniz:");
            Console.WriteLine("\t+ - Toplama");
            Console.WriteLine("\t- - Çıkarma");
            Console.WriteLine("\t* - Çarpma");
            Console.WriteLine("\t/ - Bölme");
            Console.Write("Seçiminiz? ");
            secim = Console.ReadLine();
            switch (secim)
            {
                case "+":
                    int top = sayi1 + sayi2;
                    Console.Write("toplam:" + top);
                    break;
                case "-":
                    int cikar = sayi1 - sayi2;
                    Console.Write("Çıkart:" + cikar);
                    break;
                case "*":
                    int carpim = sayi1 * sayi2;
                    Console.Write("Çarpım:" + carpim);
                    break;
                case "/":
                    int bolum = sayi1 / sayi2;
                    Console.Write("Bölüm:" + bolum);
                    break;


            }
            Console.WriteLine();

            Console.Write("Tebrikler, doğru sonuç :))) ");


            for (i = 0; i <= 5; i++)

            {

                for (int j = 0; j < i; j++)

                {

                    Console.Write("*");

                }

                Console.WriteLine("");

            }

            Console.ReadLine();

        }
    }
}
