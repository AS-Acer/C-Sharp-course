using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İfelseConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("notlarınızı giriniz : ");
            Console.Write("birinci not : ");
            int birincinot = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci not : ");
            int ikincinot = Convert.ToInt32(Console.ReadLine());
            Console.Write("üçüncü not :");
            int ucuncunot = Convert.ToInt32(Console.ReadLine());
            

            int not = (birincinot+ikincinot+ucuncunot)/3;

            if (not >= 80 && not<= 100 )
            {
                Console.WriteLine(not + " A+");
                Console.ReadLine();
            }
            else if(not <=80 && not>=60)
            {
                Console.Write(not + "A");
                Console.ReadLine();

            }
            else if (not <= 60 && not >= 40)
            {
                Console.WriteLine(not + " B");
                Console.ReadLine();
            }
            else {
                Console.Write(not + " kaldı");
                Console.ReadLine();
            }
        }
    }
}
