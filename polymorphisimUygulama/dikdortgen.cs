    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisimUygulama
{
    public class dikdortgen : sekil
    {
        public int uzunKenar { get; set; }
        public int kısaKenar { get; set; }
        public dikdortgen(string isim,int uzunKenar, int kısaKenar):base(isim)
        {
            this.kısaKenar = kısaKenar;
            this.uzunKenar = uzunKenar;
        }

        public override void sekilHesapla()
        {
            int alan = (uzunKenar * kısaKenar);
            base.sekilHesapla();
            Console.WriteLine( getIsim()+"nin alanı :"+alan);

        }
        public override void sekilBilgisiGoster()
        {
            base.sekilBilgisiGoster();
            Console.WriteLine("Kısa kenar : " + kısaKenar);
            Console.WriteLine("Uzun kenar : "+uzunKenar);
        }
    }
}
