using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticDegisken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calısan amet = new calısan();
            amet.calısanId = 1;
            amet.isim = "Ahmet ";
            amet.soyisim = "acer";
            calısan.maas = 48000;//static değişkende objeden bağımısız atama ve gösterme yapıyoruz 

            Console.WriteLine("çalışan ıd = "+ amet.calısanId);
            Console.WriteLine("çalışan isim = "+ amet.isim);
            Console.WriteLine("çalışan soyisim = "+ amet.soyisim);
            Console.WriteLine("çalışan maaş = "+calısan.maas);//static değişkende objeden bağımısız atama ve gösterme yapıyoruz 


        }
    }
}
