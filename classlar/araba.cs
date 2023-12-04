using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar
{
    internal class araba
    {
        public int kapısayısı;
        public string marka;

        public araba(int doorsayısı, string markası )//ctor kısa kodu ile bu sistem dizilebilir
        {
            kapısayısı = doorsayısı;
            marka = markası;
        }

        public void calıstırma()
        {
            Console.WriteLine("araba şuan çalışıyor...");
        }

        public void kilitle()
        {
            Console.WriteLine(  "kapılar kilitlenyor...");
        }
    }
}
