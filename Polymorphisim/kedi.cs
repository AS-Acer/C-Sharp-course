using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    public class kedi : hayvan
    {
        public kedi(string isim) : base(isim)
        {
            
        }
        public override void konus()//override komutuyla daha önce virtual olarak belirlediğimiz metodu ezip değiştiriyorız 
        // yani 1 komutla birçok farklı iş yapıyoruz
        {
            Console.WriteLine(getIsim()+" miyavlıyor");
        }
    }
}
