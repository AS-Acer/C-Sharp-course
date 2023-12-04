using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ogrenci amet = new ogrenci();

            amet.setIsim("Ahmet");// set metoduyla private değişkene değer atıyoruz.
            amet.getIsim();// get komuduyla private değişkene atadığımız isme bakıyoruz.


        }
    }
}
