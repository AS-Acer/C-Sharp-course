using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //İnterfacelerden bir tane örnek oluşturamazsınız -->> IMusteri musterimiki = new IMusteri();
            //interfacei implement eden classdan aldığımız örneği interface karşılayabilir
            //interface içerisinde metotoları tanımlarız.Classlarda da içeriği doldururuz
            //inteface içindeki metotların erişim belirleyicileri ve içeriği olmaz
            //interfaceleri miras alan sınıflar, içerisinde tanımlanan tüm metodları ımplemenete etmek zorundadır
            //bir class sadece bir classtan türetebilirken bir class birden çok ınterfaceten türetilebilir.


            Musteri musterim = new Musteri();
            musterim.ekle();
            musterim.sil();
            musterim.güncelle();

            IMusteri musterimleAynı = new Musteri();
            musterimleAynı.ekle();
            musterimleAynı.sil();
            musterimleAynı.güncelle();


        }
    }
}
