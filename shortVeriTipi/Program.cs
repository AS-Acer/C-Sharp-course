using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short veri tipi -32768 ve 32767 arası sayıları tutar

            short maxDeger = short.MaxValue;
            short minDeger = short.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
