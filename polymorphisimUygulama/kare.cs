using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisimUygulama
{
    public class kare : sekil
    {
        public int kenar  { get; set; }
        public kare(string isim, int kenar) : base(isim)
        {
            this.kenar = kenar;

        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+"nin alanı : "+(kenar*kenar));
        }
        public override void sekilBilgisiGoster()
        {
            base.sekilBilgisiGoster();
            Console.WriteLine("Şekil ismi : "+ getIsim());
            Console.WriteLine(getIsim()+"nin kenarı : "+kenar);
        }
    }
}
