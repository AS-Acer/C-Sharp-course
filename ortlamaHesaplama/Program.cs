using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ortlamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Statik dersi ortlama hesaplama motoruna hoş geldiniz.");
            Console.Write("1.Vize sonucunu :  ");
            int vize1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ödev puanını giriniz : ");
            int ödev = Convert.ToInt32(Console.ReadLine());
            double a = ((vize1 * 0.45) + (ödev * 0.15));

            double sonuc = (44-a)*(2.5) ;

            Console.WriteLine("Almanız gereken puan : " + sonuc);
            Console.ReadLine();

        }
    }
}
