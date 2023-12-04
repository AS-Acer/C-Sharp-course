using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceUygulama
{


    public class yonetici : calisan
    {
        private int calisansayisi;
        public yonetici(int id, string name, string surname, int maas, int  calisansayisii) : base(id, name, surname,maas)
        {
            this.calisansayisi = calisansayisii;
        }
        public void zamyap(int zammiktarı)
        {
            Console.WriteLine(getName()+" "+zammiktarı+" TL maaşlara zam yapmıştır . . . ");
            Console.WriteLine("Yeni maaş miktarınız : "+ (zammiktarı+GetMaas()));
        }
    }
}
