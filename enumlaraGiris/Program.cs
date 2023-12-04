using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumlaraGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gunler gunum = gunler.pazartesi;

            if(gunum == gunler.pazartesi)
            {
                Console.WriteLine("gün pazartesidir ");
            }else if (gunum== gunler.salı)
            {
                Console.WriteLine("gün salıdır ");
            }
            else if (gunum == gunler.çarşamba)
            {
                Console.WriteLine("gün çarambadır");
            }
            else if (gunum == gunler.perşembe)
            {
                Console.WriteLine("gün perşembedir ");
            }
            else if (gunum == gunler.cuma)
            {
                Console.WriteLine("gün cumadır ");
            }
            else if (gunum == gunler.cumartesi)
            {
                Console.WriteLine("gün cumartesidir ");
            }
            else if (gunum == gunler.pazar)
            {
                Console.WriteLine("gün pazardır ");
            }
            Console.ReadLine();
        }
    }
}
