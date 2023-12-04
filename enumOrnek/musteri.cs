using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumOrnek
{
    public class musteri
    {
        public int id { get; set; }
        public string isim  { get; set; }
        public string soyisim { get; set; }
        public string mailAdress { get; set; }
        public string cinsiyet { get; set; }

        public musteri(int id,string isim,string soyisim,string mailadress,string cinsiyet)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.mailAdress = mailadress;
            this.cinsiyet = cinsiyet;
            
        }

        public static ArrayList musteriler =new ArrayList();

        public musteridurum musteriekle(musteri musterim)
        {
            musteriler.Add(musterim);//musteri ekledik

            return musteridurum.kayıtbasarılı;// musteri ekleme başarılı olduğu içim enum içindeki değeri döndü
        }

    }

}
