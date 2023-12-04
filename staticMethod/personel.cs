using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethod
{
    public class personel
    {
        public static void isimSoyisimYazdır()
        {
            Console.WriteLine(" örnek isim soyisim ");
        }

        public static void sayilariTopla(int sayı1,int sayi2)
        {
            Console.WriteLine("sayiların toplamı = "+(sayı1+sayi2));
        }
    }
}
