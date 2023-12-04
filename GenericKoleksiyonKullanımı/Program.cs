using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> rakamlar = new List<int>();
            rakamlar.Add(1);
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);
            rakamlar.Add(9);
            rakamlar.Add(10);

            foreach(int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
            }



            List<musteriler> musteri = new List<musteriler>();

            musteri.Add(new musteriler(1, "Ahmet", "Acer", "ahmetacer@gmail.com"));
            musteri.Add(new musteriler(2,"Said","Acer","saidacer@gmail.com"));
            musteri.Add(new musteriler(3, "Amet", "hknup", "amethknup@gmail.com"));
            
            foreach(musteriler musterim in musteri)//musteriler sınıfından musterim adınad musteri leri döndür :)
            {
                Console.WriteLine(musterim);
            }
            
            
            Console.ReadLine();
        }
    }
}
