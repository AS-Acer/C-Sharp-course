using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Byte birinci =  5;
            Byte ikinci = 25;
            Byte ucuncu = 255; //byte veri tipi 0-255 arası sayılar için geçerlidir

            Byte maxDeger = Byte.MaxValue;
            Byte minDeger = Byte.MinValue;


            //cw kısayoludur console write 
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
