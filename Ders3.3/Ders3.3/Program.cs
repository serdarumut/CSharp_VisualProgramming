using System;

namespace EnumCalisanlar
{
    // Çalışanlar için enum yapısı
    enum Calisanlar : byte
    {
        İdareci,  // 0 -> 100 TL
        Öğretmen, // 1 -> 200 TL
        Memur,    // 2 -> 300 TL
        Hizmetli  // 3 -> 400 TL
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan çalışan tipini alıyoruz
            Console.WriteLine("Lütfen çalışan tipini seçiniz (0: İdareci, 1: Öğretmen, 2: Memur, 3: Hizmetli): ");
            byte calisanTipi = Convert.ToByte(Console.ReadLine());

            // Switch-case yapısı ile maaşları kontrol ediyoruz
            switch ((Calisanlar)calisanTipi)
            {
                case Calisanlar.İdareci:
                    Console.WriteLine("İdareci maaşı: 100 TL");
                    break;

                case Calisanlar.Öğretmen:
                    Console.WriteLine("Öğretmen maaşı: 200 TL");
                    break;

                case Calisanlar.Memur:
                    Console.WriteLine("Memur maaşı: 300 TL");
                    break;

                case Calisanlar.Hizmetli:
                    Console.WriteLine("Hizmetli maaşı: 400 TL");
                    break;

                default:
                    Console.WriteLine("Geçersiz çalışan tipi girdiniz.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
