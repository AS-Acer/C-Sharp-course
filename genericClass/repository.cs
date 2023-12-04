using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClass
{
    public class repository<T>
    {
        // tek metodla yüzlerce tipe hizmet ediyoruz t yerine hangi tip gelirse o tipte çalışıyor ;_;
        public List<T> getir()
        {
            //veriltabanında ilgili tabloya git ve ordan kayıtları getir
            return null;
        }

        public string ekle(T data)// t türünde değer alan string değer döndüren ekle metodu 
        {

            //veriltabanında ilgili tabloya gir ve ekleme yap
            return "ürün başarılı şekilde eklenmiştir "; 
        
        }
    }
}
