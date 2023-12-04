using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri musterim = new musteri(1, "Ahmet", "Acer", "mailm@gmail.com", "erkek");
            musteridurum dönendurum = musterim.musteriekle(musterim);

            if(dönendurum== musteridurum.kayıtbasarılı)
            {
                Console.WriteLine("kayıt başarılı");
            }else if(dönendurum == musteridurum.kayıtbasarısız)
            {
                Console.WriteLine("kayıt başarısız ");
            }
            else 
            {
                Console.WriteLine("Bağlantı hatası ");
            }
            Console.ReadLine(); 

        }
    }
}
