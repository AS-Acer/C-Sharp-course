using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LohinPage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hakkınız = 3;
            Console.WriteLine("HOŞGELDİNİZ");

            while (true)
            {
                
                Console.Write("Adınızı giriniz : ");
                String isim = Console.ReadLine();

                Console.WriteLine("Şifre giriniz : ");
                String sifre = Console.ReadLine();

                if (isim == "asa" && sifre =="12345")
                {
                    Console.WriteLine("Doğru giriş yaptınız aferin .");
                    break;

                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı .");
                    if (hakkınız > 0)
                    {
                        Console.Write("kalan giriş hakkınız "+hakkınız);
                        Console.WriteLine( "Tekrar deneyiniz." );
                        hakkınız -= 1;
                    }
                    else if (hakkınız==0)
                    {
                        Console.Write("kalan giriş hakkınız " + hakkınız);
                        Console.WriteLine("Yanlış deneme hakkınız dolmuştur ZORT. ");
                        break;
                    }
                }
            }Console.ReadLine();

        }
    }
}
