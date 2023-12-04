using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisimUygulama
{
    public class sekil
    {
        public string isim{ get; set; }
        public sekil(string isim)
        {

            this.isim = isim;

        }
        public string getIsim()
        {
            return this.isim;
        }
        public void  setİsim(string isim)
        {
            this.isim = isim;
        }

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor ");
        }
        public virtual void sekilBilgisiGoster()
        {
            Console.WriteLine(getIsim()+" şeklinin bilgileri : ");
        }
    }
}
