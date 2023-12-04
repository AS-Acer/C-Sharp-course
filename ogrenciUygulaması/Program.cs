using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci bilgi sistemine HOŞGELDİNİZ ! ");

            Ogrenci amet = new Ogrenci(80, 98, 66, "YTÜ", "Ahmet Said", "Acer", 21042057);

            bool kontrol = true;



            while (kontrol)
            {
                giris();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        amet.ogrenciadsoyadver();

                        break;

                    case "2":
                        double ortalama = amet.ogrenciOrtalamasıBul();
                        Console.WriteLine(ortalama);

                        break;

                    case "3":
                        amet.ogrenciOkuluNe();

                        break;

                    case "4":
                        Console.WriteLine("Çıkış yapılıyor ...");
                        kontrol = false;
                        break;

                    default:
                        Console.WriteLine("Lütfen geçerli bir değer giriniz !!!");
                        break;


                }

            }

        }
        static void giris()
        {

            Console.WriteLine("1- Öğrenci ad soyad göster.");
            Console.WriteLine("2- Öğrenci ortalamasını bul.");
            Console.WriteLine("3- Öğrenci okulunu göster.");
            Console.WriteLine("4- Çıkış");


        }

    }
}
