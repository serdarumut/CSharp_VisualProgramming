using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                // ÖDEVLER
namespace Ders3._2
{
    internal class Program
    {
        class hesapla
        {
            public double average(int[] dizi, int size)
            {
                double toplam = 0;
                int k = 0;
                for (k = 0; k < size; k++)
                {
                    if(dizi[k] == 0)
                    {
                        return 0;
                    }
                    toplam += dizi[k];
                }

                
                double avg = toplam / size;
                return avg;
        }
            static void Main(string[] args)
            {





                // 2. Klavyeden kullanıcının girdiği 10 elemanlı dizideki her bir elemanın karesi alınacak ve bir fonksiyon yardımı ile ortalaması hesaplanacaktır. Programı yazınız.

                int[] dizi1 = new int[10];

                Console.WriteLine(" Sırasıyla dizinin değerlerini giriniz : ");
                for (int i = 0; i < 10; i++)
                {
                    dizi1[i] = Convert.ToInt32(Console.ReadLine());
                }

                int[] dizi2 = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    dizi2[i] = dizi1[i] * dizi1[i];
                }

                hesapla ortal = new hesapla();

                double ortalama = ortal.average(dizi2, 10);
                Console.WriteLine("Dizinin karelerinin ortalaması: " + ortalama);
                
                Console.ReadLine();
            }
        }
    }
}
    /*
            // 1.  10 elemanlı interger sayılardan oluşan bir dizi oluşturulacak. Diziyi tersten, sıralıi string ifadeye çevrilmiş ve dizinin kullanıcının istediği
            //     elemanını ekrana yazdıran programı Array class methodları kullanarak yazınız.

            int[] dizi = new int[] { 10,9,8,7,6,5,4,3,2,1 };

            int[] dizi2 = new int[dizi.Length];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi2[i] = dizi[dizi.Length - 1 - i];
            }
            for(int j = 0; j<dizi2.Length-1; j++)
            {
                Console.Write(dizi2[j]+ " ");
            }

            Console.WriteLine("");
            
            

            
            Console.Write("İstenilen dizi değerini giriniz : ");
            int girilen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(dizi2[girilen-1]);


            Console.ReadLine();

            */




