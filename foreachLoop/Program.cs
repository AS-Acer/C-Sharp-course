using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] isimler = { "Ahmet", "Said", "Acer" };

            foreach (string a in isimler) //foreach(tür/ isim / in/  hangi dizi)
            {
                Console.WriteLine(a);
            }Console.ReadLine();
        }
    }
}
