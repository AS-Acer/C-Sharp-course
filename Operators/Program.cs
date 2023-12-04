using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
             + toplama operatörü
             - çıkarma operatörü
             / bölme operatörü
             * çarpma operatörü
             % mod alma (bölmede kalan sonuç) operatörü
             ++ sayıya +1 ekler
             -- sayıya -1 ekler
             =  atama operatörü
             == eşit olduğunu gösterir
             != eşit değildir demek için kullanılır
             >  büyüktür operatörü 
             >= büyük eşittir oparatörü
             < küçüktür operatörü
             <= küçük eşittir operatörü
             && her koşul sağlanırsa true döner (true && true = true yoksa false) 
             || veya operatörü işlemlerden birisi true ise sonuç true
             ! değil operatörü var olan bir şeyi zıttına çevirir değişken adı başına konur
             += a nın değerine ekleme yap ve yeniden a ya ata örnek olarak a + 4 = 9 yerine a+=4 diyoruz
             -= a nın değerini eksilt ve yeniden a ya ata
             /= a nın değerini böl ve tekrar a ya ata
             *= a nın değerini çarp ve tekrar a ay ata

             */


            int a = 748;
            int b = 5156;
            int c = 16844;
            int d = 100;

            a++;
            b++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int sonuc = a + b- (c+d);
            Console.WriteLine(a*d);
            Console.WriteLine(c/d);
            Console.WriteLine(c%d);
            Console.WriteLine(sonuc);

            bool kontrol = a == b;
            Console.WriteLine(kontrol);


            bool kontroll = a != b;
            Console.WriteLine(kontroll);


            bool bigOrNot = a > a;
            Console.WriteLine(bigOrNot);

            bool biggerMidur = a >= a;
            Console.WriteLine(biggerMidur);

            bool tinyOrNot = a < a;
            Console.WriteLine(tinyOrNot);

            bool tinyMidur = a <= a;
            Console.WriteLine(tinyMidur);

            bool veMidur = a == a && a != b ;
            Console.WriteLine(veMidur);

            bool veyaMidur = a == a || a != b;
            Console.WriteLine(veyaMidur);

            bool doru = true;
            Console.WriteLine(!doru);

            Console.ReadLine();
        }
    }
}
