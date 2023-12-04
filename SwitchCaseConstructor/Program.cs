using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 10000;

            Console.WriteLine("Acerbanka hoşgeldiniz yapmak istediğiniz işlemi seçiniz ");
            Console.WriteLine("1 -> bakiye görüntüleme" + "2 -> para çekme " + "3 -> para yatırma" + "q -> çıkış yapma");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    
                    Console.WriteLine("şuanki baliyeniz : " + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("çekmek istediğiniz miktarı giriniz ");
                    int cıkanpara = Convert.ToInt32(Console.ReadLine());
                    if (cıkanpara <= bakiye)
                    {
                        Console.WriteLine("çekilen miktar : " + cıkanpara);
                        Console.WriteLine("kalan bakiye : " + (bakiye - cıkanpara));
                        Console.ReadLine();


                    }
                    else
                    {
                        Console.WriteLine("yetersiz bakiye");
                        Console.ReadLine();
                    }
                    break;

                case"3":

                    Console.WriteLine("yatırmak istediğiniz miktarı giriniz :");
                    int girenpara = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yatırmak istediğiniz parayı şeye koyunuz ");
                    Console.WriteLine("şeydeki para : " + girenpara);
                    Console.WriteLine("kalan bakiye : " + (bakiye - girenpara));
                    Console.ReadLine();
                    break;

                case"4":
                    Console.WriteLine("çıkış yapılıyor");
                    Console.WriteLine("çıkış yapıldı iyi günler ");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine( "lütfen bir değer giriniz ! ");
                    Console.ReadLine();
                    break;







            }
        }
    }
}
