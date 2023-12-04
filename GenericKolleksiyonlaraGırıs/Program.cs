using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKolleksiyonlaraGırıs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList  degerlerlim = new ArrayList();// generic olmayan ve her türden değer alan bir arraylist
            degerlerlim.Add(5);
            degerlerlim.Add("Ahmet");

            

            degerEkle(5);// oluşturduğumuz arrayliste değer ekledik
        }
        static void degerEkle(int deger)//generic olmayan ve tek tipte değer alan araylist oluşturduk 
        {
            ArrayList degerler = new ArrayList();
        }
    }
}
