using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri amet = new musteri(); ;//yeni müşteri atadık

            amet.KİLO = 85;// kilo değerine set KİLO ile değer ataması yaptık

            Console.WriteLine(amet.KİLO);// atadığımız değerleri yazdırdık
        }
    }
}
