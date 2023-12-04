using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TürDönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

             İNT ----> BYTE

             int a = 5;

             byte b = (byte)a; // a yı byte tipine dönüştürdük
             Console.WriteLine(b.GetType());
             Console.WriteLine(b);



             çıktı :
             System.Byte
              5
             NOT!!!!: byte veya başka bir veri tipinin tutamayacağı kadar çok değer eklersek dönüşüm sonucu değer kaybı yaşayabiliriz

              */


            /*
             
            STRİNG ---------->İNT
           

            string sayı1 = "1";
            string sayı2 = "2";

            int c = int.Parse(sayı1);//1.yolla string to int için kullanılır genel olarak
            int d = int.Parse(sayı2);

            int e = Convert.ToInt32(sayı1);//2.yolla her zaman int dönüşümü için kullanılır
            int f = Convert.ToInt32(sayı2);

            Console.WriteLine(c+d);
            Console.WriteLine(e+f);
            Console.WriteLine(sayı1+sayı2);//stringler toplama işlemiyle yan yana yazılırlar toplanmazlar
            Console.ReadLine();

            */

            /*
            
            İnt ------> String

            int a = 9;
            int b= 10;

            string c = a.ToString();
            string d = b.ToString();

            Console.WriteLine(c+b);//string toplamı olduğu için yan yana yazdı sonuç 910
            Console.ReadLine();

            */

            /*
              
            DOUBLE ------------> İNT
            
            CONVERT.TOİNT32 KODUYLA ÇEVRİLİR
            dönüşü sonucu tam sayı kısmını çıktı verir


             */

            String kullaniciYas = Console.ReadLine();
            int yasSayisal = Convert.ToInt32(kullaniciYas);

            //kullanıcıdan aldığımız yaş değerini integera dönüştürdük 

            Console.WriteLine("yaş değeri giriniz : ");
            Console.WriteLine(yasSayisal);
            Console.ReadLine();





        }
    }
}
