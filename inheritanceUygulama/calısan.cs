using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceUygulama
{
    public class calisan
    {
        private int id;
        private string isim;
        private string soyisim;
        private int maas;

        public calisan(int id, string name, string surname,int maas)
        {
            this.id = id;
            this.isim = name;
            this.soyisim = surname;
            this.maas = maas;
        }


        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.isim;
        }
        public void setName(string name)
        {
            this.isim = name;
        }
        public string getSurname()
        {
            return this.soyisim;

        }
        public void setSurnmae(string surname)
        {
            this.soyisim = surname;

        }

        public int GetMaas()
        {
            return this.maas;
        }
        public void setmaas(int maas)
        {
            this.maas = maas;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("İd : "+this.id );
            Console.WriteLine("Ad : "+ this.isim);
            Console.WriteLine("Soyad : "+ this.soyisim);
            Console.WriteLine("maaş : "+this.maas);
           
        }

    }
}
