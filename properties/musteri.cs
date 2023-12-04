using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class musteri
    {
        private int  kilo ;

        //prop kısa koddur tab tab yaparız
        public int KİLO {
            get//get ile atanan değerleri çağırırız
            {
                return kilo ;
            }
            set//set ile değer ataması yapılır
            {
                kilo = value;//value ile dışarıdan atadığımız değeri tutarız
            }
        }
    }
}
