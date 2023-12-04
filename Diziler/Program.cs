using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //İNTEGER SERİ

            //int[] sayilar = new int[4];

            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[3] = 40;

            //for(int i = 0; i <= sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);

            //}
            //Console.ReadLine();




            //STRİNG SERİ

            //string[] isimler = { "Ahmet", "Said", "Acer" };//index ataması ile dizi oluşturabileceğimiz gibi bu şekilde de dizi oluşturabiliriz
            //for(int a= 0; a<= isimler.Length; a++)
            //{
            //    Console.WriteLine(isimler[a]);

            //}Console.ReadLine();



            //DOUBLE SERİ

            //double[] virgulluler = { 1.58, 1.64, 8.8468 };
            //for(int b =0; b <= virgulluler.Length; b++)
            //{
            //    Console.WriteLine(virgulluler[b]);

            //}

            //Console.ReadLine();



            //KULLANICIDAN DERĞER ALARAK SERİ OLUŞTURMA

            int[] serimiz = new int[4];

            for (int i = 0; i < serimiz.Length; i++)
            {
                Console.Write(  "Oluşturmak istediğiniz dizinin "+(i+1)+". değerini giriniz : " );
                serimiz[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Girdiğiniz değerlerle oluşturulan seri : ");
            for(int a= 0; a<serimiz.Length; a++)
            {
                Console.WriteLine(serimiz[a]);
            }Console.ReadLine();



        }
    }
}
