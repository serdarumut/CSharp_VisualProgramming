using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2._3
{
    internal class Program
    {                                                   // DONGULER
        static void Main(string[] args)
        {
            /*
            // if else bloklarının kullanımı


            Console.Write("Enter number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 20)
            {

                Console.WriteLine("a is greater than 20");
            }
            else if (a < 20)
            {
                Console.WriteLine("a is less than 20");
            }
            else
            {
                Console.WriteLine("a is equal to 20");
            }



            int x = 20, y = 10;
            var result = x > y ? "x is greater than y" : "x is less than y";
            
            Console.WriteLine(result);


            int z = 20, t = 10;
            if (x > y)
                Console.WriteLine("z is greater than t");
            else
                Console.WriteLine("z is less than t");


           



            
            //     switch - case
            Console.Write("0 ile 5 de dahil olmak üzere aralığında bir sayı giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 0:
                    Console.WriteLine("Sayı : 0 ");
                    break;
                case 1:
                    Console.WriteLine("Sayı : 1 ");
                    break;
                case 2:
                    Console.WriteLine("Sayı : 2 ");
                    break;
                case 3:
                    Console.WriteLine("Sayı : 3 ");
                    break;
                case 4:
                    Console.WriteLine("Sayı : 4 ");
                    break;
                case 5:
                    Console.WriteLine("Sayı : 5 ");
                    break;

            }


             */


            // for


            Console.Write("1 den 100 e kadar olan bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i <= 100; i++)
            {
                if (i  == sayi)
                {
                    Console.WriteLine("Sayi = " + i);
                }
            }



            int s = 1;
            while (s < 20)
            {
                s++;
                //check if value is not equal to 1,3,5 etc then continue for next loop
                if ((s % 2) != 0)
                {
                    continue;
                }
                Console.WriteLine("s = " + s);
            }




            Console.ReadLine();

        }
    }
}
