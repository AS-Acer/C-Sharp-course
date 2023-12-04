
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 10000;

            Console.WriteLine("Acerbanka hoşgeldiniz yapmak istediğiniz işlemi seçiniz ");
            Console.WriteLine("1 -> bakiye görüntüleme"+ "2 -> para çekme "+ "3 -> para yatırma"+ "q -> çıkış yapma");

            string secim = Console.ReadLine();
            
            

            if (secim == "1")
            {
                Console.WriteLine("şuanki baliyeniz : " + bakiye);
                Console.ReadLine();

            }
            else if (secim == "2")
            {
                Console.WriteLine("çekmek istediğiniz miktarı giriniz ");
                int cıkanpara = Convert.ToInt32(Console.ReadLine());
                if (cıkanpara<= bakiye)
                { 
                Console.WriteLine("çekilen miktar : " + cıkanpara);
                Console.WriteLine("kalan bakiye : " + (bakiye - cıkanpara));
                Console.ReadLine();


                }
                else { 
                    Console.WriteLine("yetersiz bakiye");
                    Console.ReadLine();
                }
               
            }
            else if (secim == "3")
            {
                Console.WriteLine("yatırmak istediğiniz miktarı giriniz :");
                int girenpara = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("yatırmak istediğiniz parayı şeye koyunuz ");
                Console.WriteLine("şeydeki para : " + girenpara);
                Console.WriteLine("kalan bakiye : " + (bakiye - girenpara));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("çıkış yapılıyor");
                Console.WriteLine("çıkış yapıldı iyi günler ");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("geçerli değer giriniz");
                Console.ReadLine();
            }
        }
    }
}
