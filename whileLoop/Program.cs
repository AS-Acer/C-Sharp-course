using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;

            //while (a <= 10)
            //{  
               
            //    Console.WriteLine(a); 
            //    a++;// kod okunma mantığı sebebiyle önce yazıp sonra arttırması gerekli yoksa değer aralığı 2-11 olur

            //}
            //Console.ReadLine();

            int b = 100;
            while (b >= 0)
            {
                Console.WriteLine(b);
                b -= 2;
            }
            Console.ReadLine();
        }
    }
}
