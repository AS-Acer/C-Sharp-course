using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClasslar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asbtract classlar tamamen kalıtım amaçlı geliştirilmiştir  // yeni eleman da oluşturamayrul --> temelsınıf temelvedursun = new temelsınıf();
            // içerisinde tanımlanmış metot imzalarını miras alan classları override etmek zorundadır

            //normal classlarda metot imzası tanımı yapamaz iken abstract classlarda metot imzası yapılr
            // normal classlarda new anahatar kelimesi ile nesneler oluşturabilirken abstrack classlarda yapamayız --> temelsınıf temelvedursun = new temelsınıf();

            //bir sınıfta abstact classlardan sadece birini miras alabilirken o class birden çok interfacei implemente edebilir 


            altsınıf altan = new altsınıf();
            altan.metot1();
            altan.metot2();
            Console.ReadLine();

        }
    }
}
