using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    public class hayvan
    {
        public string isim { get; set; }
        public hayvan(string isim)
        {
            this.isim = isim;
        }
        public string getIsim()
        {
            return this.isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public virtual  void konus()
        {
            Console.WriteLine("Hayvan konuşuyor ");
        }
    }
}
