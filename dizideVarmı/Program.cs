using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizideVarmı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 10, 10, 10, 0, 10, 1, 1, 01, 0, 10, 175, 785, 75, 74, 74, 74, 74, 7, 72, 8, 245, 27, 4, 275, 2157, 14, 2, 653, 2, 174, 742, 5, 2, 52, 7, 175, 2, 75, 174, 12, 75, 24, 1, 4, 275, 50, 45, 204, 5, 745, 275, 27, 5827, 52, 785, 278, 52, 782, 78, 27, 852, 7582, 752, 752, 0 };
            int adet = 0;
            int alinanSayi;

            Console.Write("Aramak istediğiniz sayıyı giriniz : ");
            alinanSayi = Convert.ToInt32(Console.ReadLine());


            for (int a = 0; a < sayilar.Length; a++)
            {
                if (alinanSayi == sayilar[a])
                {
                    adet++;

                }
            }

            if (adet == 0)

            {

                Console.WriteLine("girdiğiniz değer listede yok .");
                Console.ReadLine();

            }


            else
            {
                Console.WriteLine("Girdiğiniz değer listede " + adet + " adet bulundu .");
                Console.ReadLine();


            }

        }

    }
}

