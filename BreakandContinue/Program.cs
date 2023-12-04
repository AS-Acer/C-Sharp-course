using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakandContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                   // break;//break komutuyla istenen özellik sağlanınca döngü kırılır
                    continue;//continue comutuyla istenen özellik bypass edilir

                }
                Console.WriteLine(a);
            }Console.ReadLine();
        }
    }
}
