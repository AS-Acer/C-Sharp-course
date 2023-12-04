using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba mustang = new araba(4,"ford");// araba sınıfı türünde yeni bir obje atadık
            // parantez içinde default olarak gerekli olan değerleri atayarak obje tanımlarken özelliklerinide yanında atarız 

            // araba sınıfı özelliklerini atadık
            mustang.kapısayısı = 5;
            mustang.marka = "ford";
            mustang.kilitle();
            mustang.calıstırma();

            Console.ReadLine();

        }
    }
}
