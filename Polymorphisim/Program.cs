using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    internal class Program
    {
        static void Main(string[] args)

        {

            /* 
              BİRİNCİ YOL

              hayvan hayvanbir = new hayvan("Default hayvan");
              hayvanbir.konus();

              kedi kedicik = new kedi("Keydifi");
              kedicik.konus();
           
            hayvan kediiki = new kedi("kedicik");//hayvan sınıfı üzerinden de kedi sınıfından bir elemanı oluşturabiliriz

            

              kopek kucukucu = new kopek("kuçu kuçu ");
              kucukucu.konus();

              Console.ReadLine();



              2.yol :

             */


            hayvanlarıkonustur(new kedi("minnoş"));// static metodla yeni kedi oluşturup isim verdik
            hayvanlarıkonustur(new kopek("kopekçik"));
            Console.ReadLine();
        }
        public static void hayvanlarıkonustur(hayvan hayvan)// hayvan sınıfından hayvan özelliklerini alacağını söyledik
        {
            hayvan.konus();
        }
    }
}
