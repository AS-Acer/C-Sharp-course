using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("boy kitle endeksi hesaplama motoruna hoşgeldiniz ");
            Console.WriteLine("boyunuzu giriniz :");
            int boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kilonuzu giriniz : ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("boyunuz : "+ boy);
            Console.WriteLine("kilonuz : "+ kilo);

            double indeks = kilo / (boy * boy);
            Console.WriteLine(indeks);

            if (indeks<= 18)
            {
                Console.WriteLine(indeks+" zayıf");
                Console.ReadLine();
            }
            else if (indeks > 18 && indeks <=35)
            {
                Console.WriteLine(indeks+" normal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(indeks + " obez / sağlıksız");
                Console.ReadLine();
            }
        }
    }
}
