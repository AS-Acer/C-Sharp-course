using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneOtomasyonu
{
    public class kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyad { get; set; }
        public DateTime girisTarihi  { get; set; }
        public string username { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }


        public kisi()
        {
            
        }

        public kisi(int id, string isim, string soyisim,DateTime girisTarihi,string username,string sifre,string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyad= soyisim;
            this.girisTarihi= girisTarihi;
            this.username = username;
            this.sifre = sifre;
            this.yetki= yetki;
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getIsim()
        {
            return isim;
        }
        public void setIsım(string isim)
        {
            this.isim= isim;
        }
        public string getSoyisim()
        {
            return soyad;
        }
        public void setSoyisim(string soyad)
        {
            this.soyad= soyad;
        }
        public DateTime getGirisTarihi()
        {
            return girisTarihi;
        }
        public void setGirisTarihi(DateTime girisTarihi)
        {
            this.girisTarihi = girisTarihi;
        }
        public string getUsername()
        {
            return username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public string getSifre()
        {
            return sifre;
        }
        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getYetki()
        {
            return yetki;
        }
        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }

        public override string ToString()
        {
            return "Ad-Soyad : " + this.isim + " " + this.soyad;
        }
    }
}
