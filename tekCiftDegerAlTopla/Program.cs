using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekCiftDegerAlTopla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teksayilar = 0;
            int ciftsayilar = 0;
            int tektoplamı = 0;
            int cifttoplamı = 0;
            int girensayi;

            int[] liste = new int[10];
            for (int i = 0; i < liste.Length; i++)
            {
                Console.Write((i + 1) + ". sayı değerini giriniz : ");
                girensayi = Convert.ToInt32(Console.ReadLine());
                liste[i] = girensayi;

            }

            for (int j = 0; j < liste.Length; j++)
            {
                if (liste[j] % 2 == 0)
                {
                    ciftsayilar++;
                    cifttoplamı += liste[j];
                }
                else
                {
                    teksayilar++;
                    tektoplamı += liste[j];

                }
            }



            if (cifttoplamı > tektoplamı)
            {
                Console.WriteLine("Çift sayılar toplamı tek sayılar toplamından büyük çıkmştır :");
                Console.WriteLine("* * * * * *  Sayı Toplamları* * * * * * * * *");
                Console.WriteLine("Çift sayılar toplamı : " + cifttoplamı);
                Console.WriteLine("Tek sayılar toplamı : " + tektoplamı);
                Console.WriteLine("* * * * * * * *Sayı Adetleri* * * * * * * *");
                Console.WriteLine("Çift sayı adedi: " + ciftsayilar);
                Console.WriteLine("Tek sayılar adedi: " + teksayilar);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Çift sayılar toplamı tek sayılar toplamından küçük çıkmştır :");
                Console.WriteLine("* * * * * *  Sayı Toplamları* * * * * * * * *");
                Console.WriteLine("Çift sayılar toplamı : " + cifttoplamı);
                Console.WriteLine("Tek sayılar toplamı : " + tektoplamı);
                Console.WriteLine("* * * * * * * * Sayı Adetleri * * * * * * * *");
                Console.WriteLine("Çift sayı adedi: " + ciftsayilar);
                Console.WriteLine("Tek sayılar adedi: " + teksayilar);
                Console.ReadLine();

            }



        }
    }
}
