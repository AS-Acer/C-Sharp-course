using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisimUygulama
{
    public class ucgen  :sekil
    {
        public int tabanAlanı { get; set; }
        public int yukseklik { get; set; }

        public ucgen(string isim, int tabanAlanı, int yukseklik) : base(isim)
        {
            this.tabanAlanı = tabanAlanı;
            this.yukseklik = yukseklik;
        }

        public override void sekilHesapla()
        {
            double ucgenalanı = (tabanAlanı * yukseklik) / 2;
            base.sekilHesapla();
            Console.WriteLine(getIsim()+"nin alanı  "+ucgenalanı);
        }
        public override void sekilBilgisiGoster()
        {
            base.sekilBilgisiGoster();
            Console.WriteLine("Taban Alanı : "+ tabanAlanı);
            Console.WriteLine("Yükseklik : "+ yukseklik);

        }
    }
}
