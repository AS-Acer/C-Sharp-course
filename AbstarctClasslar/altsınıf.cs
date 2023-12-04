using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClasslar
{
    public class altsınıf : temelsınıf
    {
        public override void metot2()// temel sınıfı iherit ettiğimizde abstract metoduda override olarak implement etmek zorundayız 
        {
            Console.WriteLine("metod 2 çalıştı ");
        }
    }
}
