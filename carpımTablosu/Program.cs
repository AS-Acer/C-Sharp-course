using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int a= 1; a<11; a++)
            {
                for (int k = 1; k < 11; k++) 
                {
                    Console.WriteLine(a + " x " + k + " = " + (a * k));

                }
            }Console.ReadLine();
        }
    }
}
