using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metodlar yarıdmıyla uzun kodlu işlemleri vs bir çok yerde kısa şeklide kullanabiliriz






            selamlama();//metodu çağırdık
            toplama(5, 78);
            carpma(5, 8, 6);
            isimlendirme("Ahmet Said", "Acer");






            //metodları kullanarak koşul oluşturabiliriz
            int donendeger = toplamaYap(8641, 165);

            if (donendeger > 100)
            {
                Console.WriteLine("Sonuç 100'den büyüktür : " + donendeger);
            }
            else if (donendeger == 100)
            {
                Console.WriteLine("Sonuç 100'e eşittir.");
            }
            else
            {
                Console.WriteLine("Sonuç 100'den küçüktür : " + donendeger);
            }







            Console.WriteLine(adlandırma("Siorre ", "Software"));

            Console.Write("Karesini almak istediğiniz sayıyı giriniz : ");
            int karesayısı = Convert.ToInt32(Console.ReadLine());
            int kareli = kare(karesayısı);

            if (kareli > 25)
            {
                Console.WriteLine("Sayının karesi 25'ten büyüktür : " + kareli);
            }
            else if (kareli == 25)
            {
                Console.WriteLine("Sayının karesi 25'tir : " + kareli);
            }
            else
            {
                Console.WriteLine("Sayının karesi 25'ten küçüktür : " + kareli);
            }




            Console.Write("Tek mi çift mi oldğunu öğrenmek istediğiniz sayıyı giriniz : ");
            int girilensayi = Convert.ToInt32(Console.ReadLine());
            tekorcıft(girilensayi);



            Console.WriteLine("Sayı karşılaştırma bölümüne hoşgeldiniz !!!");
            
            Console.Write("Karşılaştırmak istediğiniz 1.sayıyı giriniz : " );
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Karşılaştırmak istediğiniz 2.sayıyı giriniz : " );
            int say2 = Convert.ToInt32(Console.ReadLine());
            whichoneisbigger(sayı1, say2);


            Console.ReadLine();

        }


        //parametresiz - geriye değer döndürmeyen metod örneği
        static void selamlama()//metod oluşturup ad verdik
        {
            Console.WriteLine("Hello !");//metoda komut atadık

        }


        //parametre alan - geriye değer döndürmeyen metod örneği
        static void toplama(int a, int b)
        {
            Console.WriteLine("Toplama işlemi sonucunuz : " + (a + b));
        }

        static void carpma(int a, int b, int c)
        {
            Console.WriteLine("Çarpma işlem sonucunuz : " + (a * b * c));
        }

        static void isimlendirme(string ad, string soyad)
        {
            Console.WriteLine("Sisteme kayıtlı isim soyisim : " + ad + " " + soyad);
        }

        //parametreli ve geriye değer döndüren metod örneği

        static int toplamaYap(int a, int b)//void kullanmadık sadece int türünde işlem yapan bir metod oluşturduk
        {
            int sonuc = (a + b);
            return sonuc;// return çağrıldığı yere ne göndereceğimizi yazdığımız yer; bir nevi kurye 
        }
        static string adlandırma(string ad, string soyad)
        {
            return ad + " " + soyad;//return altına kod yazılırsa okunmaz (kurye gittikten sonra sipariş gitmez)
        }

        //ÖRNEK-1

        static int kare(int a)
        {

            return a * a;
        }

        //ÖRNEK-2

        static void tekorcıft(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir. ");
            }
        }

        //ÖRNEK-3

        static void whichoneisbigger(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a + " büyüktür ");
            }
            else if (a < b)
            {
                Console.WriteLine(b + " büyüktür ");
            }
            else
            {
                Console.WriteLine("Girilen değerler eşittir .");
            }
        }
    }
}
