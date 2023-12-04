using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticYapıcıMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            eleman amet = new eleman(1,"Ahmet","Acer"," Ytü inşaat 2.sınıf ");
            amet.information();
            amet.zamYap(6513156);
            Console.ReadLine();


            // static yapıcı metod sadece 1 kere çalışır tekrar çalışmaz 
            // erişim belirleyicisi almaz
            // parametre almaz (int id )gibi
        }
    }
}
