using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getterSetter
{
    public class ogrenci
    {
        private string isim;
        private int tc;

        public void setIsim(string _isim) //set ile private değişkene isim ataması yapıyoruz .
        {
            isim = _isim;
        }
        public string getIsim ()// get ile atanan ismi çağırıyoruz.
        {
            return isim;
        }
    }
}
