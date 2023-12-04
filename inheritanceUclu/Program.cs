using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceUclu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SEALED ANAHATAR KELİMESİNİ YAZARSAK BAŞKA BİR CLASSDAN ERİŞİLEMEZ 


            kedi cat = new kedi();
            cat.isim = "cat";
            cat.ayaksayısı = 4;
            cat.cinsiyet = "kız";
            cat.kilo= 3.5;
            cat.renk = "beyaz";
            cat.sescıkar();
            cat.hayvanbilgilerigoster();
            Console.ReadLine();


        }
    }
}
