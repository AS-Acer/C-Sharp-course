using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackClassOrnek
{
    public abstract class ay
    {
        public int kacsaat()  //sabit olacak metodu direkt doldurduk
        {
            return 24;
        }
        public abstract int kacıncıay(); // değişebilecek metodu abstract olarak belirledik
        public abstract int kacgun();

    }
}
