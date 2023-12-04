using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static metodlar ile obje oluşturmadan direkt claas ismi üzerinden metod çalıştırabiliriz
            personel.isimSoyisimYazdır();
            personel.sayilariTopla(952564, -6500161);
            Console.ReadLine();
        }
    }
}
