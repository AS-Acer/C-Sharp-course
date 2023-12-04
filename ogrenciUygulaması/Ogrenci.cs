using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciUygulaması
{
   public class Ogrenci
    {

        private int ogrenciNosu;
        private string ogrenciAdı;
        private string ogrenciSoyadı;
        private string okulAdı;
        private int vize1;
        private int vize2;
        private int final;


        public Ogrenci(int sınav1, int sınav2, int finale, string scholname, string stname, string stsname,int stno)
        {
            okulAdı = scholname;
            vize1 = sınav1;
            vize2 = sınav2;
            final = finale;
            ogrenciAdı = stname;
            ogrenciSoyadı = stsname;
            ogrenciNosu = stno;

        }
        public void ogrenciadsoyadver()
        {
            Console.WriteLine("Öğrenci adı ve soyadı : "+ ogrenciAdı+ " "+ ogrenciSoyadı );
            Console.WriteLine("Öğrenci okul numarası : "+ ogrenciNosu);

        }

        public double ogrenciOrtalamasıBul()
        {
            return (vize1 + vize2 + final) / 3;
            

        }
        public void ogrenciOkuluNe()
        {
            Console.WriteLine("Öğrenci okulu adı : " + okulAdı );
        }
    }
}
