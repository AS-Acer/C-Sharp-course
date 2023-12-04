using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace publicPrivateErisimBelirleyicisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            müsteri amet = new müsteri();

            amet.ad = "Ahmet";
            amet.soyad = "Acer";
            amet.cinsiyet = "erkek";
            //amet.yas'a değer atayamıyoruz çünkü private sınıf olduğu için sadece atandığı class içinde erişim sağlanabilir.


            amet.bilgileriver();
            //amet.isimyaz metodu çalışmıyor çünkü private metod sadece atandığı class içinde erişilebilir.
            
            Console.ReadLine();


        }

        
    }
}
