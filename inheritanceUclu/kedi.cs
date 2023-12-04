using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceUclu
{
    public class kedi : kopek
    {
        public void sescıkar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor . . . ");
        }
        public void hayvanbilgilerigoster()
        {
            Console.WriteLine("hayvan adı : " + isim);
            Console.WriteLine("hayvan rengi : "+ renk);
            Console.WriteLine("hayvan kilosu : "+ kilo);
            Console.WriteLine("hayvan ayak sayısı : "+ ayaksayısı);
            Console.WriteLine("hayvan cinsiyeti : "+ cinsiyet);
        }
    }
}
