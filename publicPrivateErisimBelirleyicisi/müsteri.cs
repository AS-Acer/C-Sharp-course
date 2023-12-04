using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicPrivateErisimBelirleyicisi
{
    internal class müsteri
    {
        public string ad;
        public string soyad;
        public string cinsiyet;
        private int yas;

        public müsteri()
        {
            Console.WriteLine("müsteri sınıfının yapıcı metodu çalıştı");
        }

        private void isimyaz(string ad, string soyad)
        {
            Console.WriteLine("isim ve soyisim : "+ad+ " "+soyad);
        }

        public void bilgileriver()
        {
            Console.WriteLine("isim : " + ad);
            Console.WriteLine("soyisim : "+ soyad);
            Console.WriteLine("cinsiyet : "+cinsiyet);
        }
    }


}
