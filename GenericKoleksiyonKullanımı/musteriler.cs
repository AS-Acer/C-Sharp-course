using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonKullanımı
{
    public class musteriler
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string  mail { get; set; }

        public musteriler(int id,string isim,string soyisim,string mail)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim= soyisim;
            this.mail = mail;
            
        }
        public override string ToString()
        {
            //to string metodunu ezerek musteriler sınıfını yazdırmak isteyince yazılacak bilgileri buraya yazdık
            return "id: " + this.id + " " + "isim: " + this.isim + " " + "Soyisim: " + this.soyisim + " " + "mail: " + this.mail; 
        }
    }
}
