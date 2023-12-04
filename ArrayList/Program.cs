using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListKullanımı

{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Ahmet");// add metoduyla yeni eleman ekliyoruz
            koleksiyon.Add("Said");
            koleksiyon.Add("Acer");

            koleksiyon.Remove("Acer");// remove metoduyla yazdığımız elemanı siliyoruz
            int sayısı = koleksiyon.Count;// count metoduyla eleman sayısına bakıyoruz
            koleksiyon.Clear();//clear ile listenin tamamını temizliyoruz
            bool kontrolef = koleksiyon.Contains("Ahmet");// dizi içinde varsa true yoksa false dönüyor
            int sırası = koleksiyon.IndexOf("Said");// verilen değerin index değerini söyler
            koleksiyon.Insert(4, "Yasin");//4.indekse Yasin değerini atar
            koleksiyon.Reverse();//diziyi ters çevirir

            foreach ( string i in koleksiyon )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Dizinin eleman sayısı : "+ sayısı);
            Console.WriteLine("Dizide eleman varsa true yoksa false sonuç : "+ kontrolef);
            Console.WriteLine("Aranan değerin index  numarası : "+sırası);
            
            */
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(5);
            rakamlar.Add(4);
            rakamlar.Add(0);
            rakamlar.Add(54);
            rakamlar.Add(3);
            rakamlar.Add(219215);


            rakamlar.Sort();//rakamlar dizisini büyükten küçüğe sıralar

            foreach (var a in rakamlar)
            {
                Console.WriteLine(a);
            }



            Console.ReadLine();

        }
    }
}
