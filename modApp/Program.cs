using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ortalasını almak istediğiniz değerini yazınız :");
            int verilenSayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for(int i = 0; i <= verilenSayi; i++) 
            {
                toplam += i;
               
            } 
            double ortalama = toplam / verilenSayi;
                Console.WriteLine(ortalama);

            if (ortalama > 50)
            {
                Console.WriteLine("Ortalaması 50 den büyüktür");
                Console.ReadLine();
            }
            else if (ortalama < 50)
            {
                Console.WriteLine("ortlama 50 den küçüktür ");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("ortalamanız 50 dir");
                Console.ReadLine();
            }

        }
    }
}
