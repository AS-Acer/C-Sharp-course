using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            repository<musteri> musterirepositorysi = new repository<musteri>();
            List<musteri> musterilerim =musterirepositorysi.getir();//musterilierimin listesini veritabanından çekip tutma     

            musteri musterim = new musteri();
            musterim.isim = "amet";
            musterim.cinsiyet = "erkek";

            musterirepositorysi.ekle(musterim);

            
            
            repository<urun> urunrepositoryisi = new repository<urun>();
            List<urun> urunlerim = urunrepositoryisi.getir();

            urun urun1 = new urun();
            urun1.isim = "araba";
            urun1.urunid = 34521536;
            urun1.fiyat = 846496.5785;

            string cikti = urunrepositoryisi.ekle(urun1);

            Console.WriteLine(cikti);

            Console.ReadLine(); 


        }
    }
}
