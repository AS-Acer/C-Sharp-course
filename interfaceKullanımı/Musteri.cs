using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceKullanımı
{
    public class Musteri : IMusteri,IPersonel //ımusteriyi inherite ettikten sonra metodlarını impleme
    {
        public void ekle()
        {
            Console.WriteLine("Müşteri eklendi ");
        }

        public void güncelle()
        {
            Console.WriteLine("Müşteri güncellendi ");
        }

        public string personelEkle()
        {
             String ekle ="Personel eklendi ";
            return ekle;

        }

        public void sil()
        {
            Console.WriteLine("Müşteri silindi ");
        }
    }
}
