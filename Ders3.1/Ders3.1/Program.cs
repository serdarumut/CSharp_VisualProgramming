using System;
                                               //diziler
namespace Ders3._1
{
    internal class Program
    {
         class MyArray
        {
            public double getAverage(int[] arr, int size)
            {
                int i;
                double avg;
                int sum = 0;
                for (i = 0; i < size; i++)
                {
                    sum += arr[i];
                }
                return avg = (double)sum / size;
            }
        }
        static void Main(string[] args)
        {

            MyArray app = new MyArray();

            int[] balance = new int[] { 1000, 12, 2, -4, 121, 100 };
            double avg;

            avg = app.getAverage(balance,6);
            Console.WriteLine( "Avarage Value is :   {0}", avg);
            Console.ReadLine();
  
        }
    }
}
/*
         int[] n = new int[10]; // n is an array of 10 integers 
         int i, j;
         // initialize elements of array n 
         for (i = 0; i < 10; i++)
         {
             n[i] = i + 100;
         }
         // output each array element's value 
         for (j = 0; j < 10; j++)
         {
             Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }
         Console.ReadKey();
         
 
 
 
 
 
 
 Property : Description
IsFixedSize:
Dizinin sabit boyutlu olup olmadığını belirten bir değer döner.

int[] dizi = new int[5];
Console.WriteLine(dizi.IsFixedSize); // true

IsReadOnly:
Dizinin salt okunur olup olmadığını belirten bir değer döner.

int[] dizi = new int[5];
Console.WriteLine(dizi.IsReadOnly); // false

Length:
Dizinin tüm boyutlarındaki eleman sayısını 32-bit tamsayı olarak döner.

int[] dizi = new int[] {1, 2, 3, 4, 5};
Console.WriteLine(dizi.Length); // 5

LongLength:
Dizinin tüm boyutlarındaki eleman sayısını 64-bit tamsayı olarak döner.

long[] dizi = new long[] {1, 2, 3, 4, 5};
Console.WriteLine(dizi.LongLength); // 5

Rank:
Dizinin kaç boyutlu olduğunu döner.
int[,] dizi = new int[3, 4];
Console.WriteLine(dizi.Rank); // 2
 
 
 
 
 
 Methods : Desciption
Clear:
Dizinin belirtilen bir aralığındaki elemanları sıfıra, false’a veya null’a ayarlar.

int[] dizi = {1, 2, 3, 4, 5};
Array.Clear(dizi, 1, 2); // 1. indexten itibaren 2 eleman sıfırlanır
foreach (var item in dizi) Console.WriteLine(item); // 1 0 0 4 5

Copy(Array, Array, Int32):
Bir dizinin elemanlarını başka bir diziye kopyalar.

int[] kaynak = {1, 2, 3};
int[] hedef = new int[3];
Array.Copy(kaynak, hedef, 3);
foreach (var item in hedef) Console.WriteLine(item); // 1 2 3

CopyTo(Array, Int32):
Bir dizinin elemanlarını belirtilen bir indexten başlayarak başka bir diziye kopyalar.

int[] kaynak = {1, 2, 3};
int[] hedef = new int[5];
kaynak.CopyTo(hedef, 2); // 2. indexten itibaren kopyalanır
foreach (var item in hedef) Console.WriteLine(item); // 0 0 1 2 3

GetLength:
Belirtilen boyuttaki eleman sayısını döner.

int[,] dizi = new int[2, 3];
Console.WriteLine(dizi.GetLength(1)); // 3

GetLongLength:
Belirtilen boyuttaki eleman sayısını 64-bit olarak döner.

long[,] dizi = new long[2, 3];
Console.WriteLine(dizi.GetLongLength(1)); // 3


GetLowerBound:
Dizinin belirtilen boyutundaki en küçük dizin değerini döner.

int[,] dizi = new int[2, 3];
Console.WriteLine(dizi.GetLowerBound(0)); // 0


GetType:
Mevcut nesnenin türünü döner.

int[] dizi = new int[5];
Console.WriteLine(dizi.GetType()); // System.Int32[]

GetUpperBound:
Dizinin belirtilen boyutundaki en büyük dizin değerini döner.

int[,] dizi = new int[2, 3];
Console.WriteLine(dizi.GetUpperBound(1)); // 2

GetValue(Int32):
Belirtilen konumdaki değeri döner.

int[] dizi = {1, 2, 3};
Console.WriteLine(dizi.GetValue(1)); // 2

IndexOf(Array, Object):
Belirtilen nesneyi arar ve ilk bulunduğu konumdaki dizini döner.

int[] dizi = {1, 2, 3, 4};
Console.WriteLine(Array.IndexOf(dizi, 3)); // 2

Reverse(Array):
Dizideki elemanların sırasını tersine çevirir.

int[] dizi = {1, 2, 3, 4};
Array.Reverse(dizi);
foreach (var item in dizi) Console.WriteLine(item); // 4 3 2 1

SSetValue(Object, Int32):
Belirtilen indexten başlayarak dizinin bir elemanına değer atar.

int[] dizi = new int[5];
dizi.SetValue(99, 2); // 2. indexe 99 atanır
Console.WriteLine(dizi[2]); // 99

Sort(Array):
Dizi elemanlarını sıralar.

int[] dizi = {4, 1, 3, 2};
Array.Sort(dizi);
foreach (var item in dizi) Console.WriteLine(item); // 1 2 3 4
 
ToString:
Nesnenin metin gösterimini döner. 
 
int[] dizi = {1, 2, 3};
Console.WriteLine(dizi.ToString()); // System.Int32[]

 
 
 
 */