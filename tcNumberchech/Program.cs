using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcNumberchech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tcno personal = new tcno();
            personal.TCNumber = "12345678910";
            Console.WriteLine("Tc kimlik numaranız : " + personal.TCNumber);
        }
    }
}
