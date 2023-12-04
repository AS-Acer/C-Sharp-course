using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClasslar
{
    public abstract class temelsınıf // abstrack ekini ekliyoruz
    {
        public void metot1()
        {
            Console.WriteLine("metot bir çalıştı");
        }

        public abstract void metot2(); //abstract anahtarıyla metodun imzası dediğimiz bodysiz metod tanımlayabiliriz

    }
}
