using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();//konsole readline loop içerisine yazılırsa her döngüde bir loop durur


            for(int a =-99; a<=99; a += 3)//a +=3 demek a=a+3 demektir yani a ya her seferinde 3 ekle
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
