using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackClassOrnek
{
     class Program 
    {
       static void Main(string[] args)
        {
            ocak ocakım = new ocak();
            Console.WriteLine("Ocak");
            Console.WriteLine(ocakım.kacsaat()+ " saat bir gün ");
            Console.WriteLine(ocakım.kacgun()+ " gün");
            Console.WriteLine(ocakım.kacıncıay()+".ay");

            ay subatum = new subat();
            Console.WriteLine("Şubat");
            Console.WriteLine(subatum.kacsaat()+ " saat bir gün");
            Console.WriteLine(subatum.kacgun()+" gün");
            Console.WriteLine(subatum.kacıncıay()+".ay");

            ay martum = new mart();
            Console.WriteLine("Mart");
            Console.WriteLine(martum.kacsaat()+ " saat bir gün");
            Console.WriteLine(martum.kacgun() + " gün");
            Console.WriteLine(martum.kacıncıay()+".ay");

            ay nisanım = new nisan();
            Console.WriteLine("Nisan");
            Console.WriteLine(nisanım.kacsaat()+ "  saat bir gün");
            Console.WriteLine(nisanım.kacgun() + " gün");
            Console.WriteLine(nisanım.kacıncıay()+".ay");

            Console.ReadLine();


        }

       
    }
}
