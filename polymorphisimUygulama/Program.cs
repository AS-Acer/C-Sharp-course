using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisimUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil hesap uygulmasına hoşgeldiniz ");

            while (true)
            {
                Console.WriteLine("İşlem seçiniz : ");
                Console.WriteLine("1- Dikdörtgen işlemleri ");
                Console.WriteLine("2- Üçgen işlemleri ");
                Console.WriteLine("3- Kare işlemleri ");
                Console.WriteLine("4- çıkış");

                string secim = Console.ReadLine();
                if (secim == "4")
                {
                    Console.WriteLine("çıkış yapılıyor...");

                    break;
                }
                else if (secim == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Dikdörtgen alanı hesaplama ");
                        Console.WriteLine("2-Dikdörtgen bilgilerini göster");
                        Console.WriteLine("3- Dikdörtgen işlemlerinden çıkış");

                        string secimdikdortgen = Console.ReadLine();

                        if (secimdikdortgen == "1")
                        {
                            Console.Write("Kısa kenar için sayısal değer giriniz : ");
                            int kısaKenar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Uzun kenar için sayısal değer giriniz : ");
                            int uzunKenar = Convert.ToInt32(Console.ReadLine());

                            dikdortgen dikdortgenim = new dikdortgen("Dikdörtgen", uzunKenar, kısaKenar);
                            dikdortgenim.sekilHesapla();

                        }
                        else if (secimdikdortgen == "2")
                        {
                            Console.Write("Kısa kenar için sayısal değer giriniz : ");
                            int kısaKenar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Uzun kenar için sayısal değer giriniz : ");
                            int uzunKenar = Convert.ToInt32(Console.ReadLine());

                            dikdortgen dikdortgenim = new dikdortgen("Dikdörtgen", uzunKenar, kısaKenar);
                            dikdortgenim.sekilBilgisiGoster();

                        }
                        else if (secimdikdortgen == "3")
                        {
                            Console.WriteLine("çıkış yapılıyor...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir tuşlama yapınız !");

                        }
                    }
                }
                else if (secim == "2")
                {
                    while (true)
                    {

                        Console.WriteLine("1-Üçgen alanı hesaplama ");
                        Console.WriteLine("2-Üçgen bilgilerini göster");
                        Console.WriteLine("3- Üçgen işlemlerinden çıkış");

                        string secimucgen = Console.ReadLine();
                        if (secimucgen == "1")
                        {
                            Console.Write("Taban alanı için sayısal değer giriniz : ");
                            int tabanAlanı = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Yükseklik için sayısal değer giriniz : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            ucgen ucgenim = new ucgen("Üçgen", tabanAlanı, yukseklik);
                            ucgenim.sekilHesapla();
                        }
                        else if (secimucgen == "2")
                        {

                            Console.Write("Taban alanı için sayısal değer giriniz : ");
                            int tabanAlanı = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Yükseklik için sayısal değer giriniz : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            ucgen ucgenim = new ucgen("Üçgen", tabanAlanı, yukseklik);
                            ucgenim.sekilBilgisiGoster();

                        }
                        else if (secimucgen == "3")
                        {
                            Console.WriteLine("çıkış yapılıyor...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir tuşlama yapınız !");


                        }
                    }
                }
                else if (secim == "3")
                {


                    while (true)
                    {
                        Console.WriteLine("1-Kare alanı hesaplama ");
                        Console.WriteLine("2-Kare bilgilerini göster");
                        Console.WriteLine("3- Kare işlemlerinden çıkış");

                        string secimkare = Console.ReadLine();
                        if (secimkare == "1")
                        {
                            Console.Write("Karenin bir kenar ölçüsü için sayısal değer giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            kare karem = new kare("Kare", kenar);
                            karem.sekilHesapla();

                        }
                        else if (secimkare == "2")
                        {
                            Console.Write("Karenin bir kenar ölçüsü için sayısal değer giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            kare karem = new kare("Kare", kenar);
                            karem.sekilBilgisiGoster();
                        }
                        else if (secimkare == "3")
                        {
                            Console.WriteLine("çıkış yapılıyor...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir tuşlama yapınız !");
                        }
                    }
                }
            }

        }
    }
}
