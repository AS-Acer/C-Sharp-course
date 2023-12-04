using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadlineKomutu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // readline komutuyla kullanıcıdan bilgi alabiliriz 


            Console.WriteLine( "Adınızı giriniz :" );
            String isim = Console.ReadLine();

            Console.WriteLine(  "Soyad Giriniz : ");
            String soyisim = Console.ReadLine();


            Console.WriteLine("isminiz : " + isim);
            Console.WriteLine("soyadınız : " + soyisim);
            
            Console.ReadLine();
            
        }
    }
}
