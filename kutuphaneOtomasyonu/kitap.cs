using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneOtomasyonu
{
    public class kitap
    {
        public int kitapID { get; set; }
        public string kitapAd { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDil { get; set; }
        public string kitapYayınevi { get; set; }
        public string kitapTur { get; set; }
        public int adet { get; set; }
        public int sayfaSayısı { get; set; }
        public int basımYılı { get; set; }

        public kitap(int kitapId,string kitapAd,string kitapYazar,string kitapDil,string kitapYayınevi,string kitapTur,int adet,int sayfasayısı,int basımyılı)
        {
            this.kitapID= kitapId;
            this.kitapAd=kitapAd;
            this.kitapYazar = kitapYazar;
            this.kitapDil=kitapDil;
            this.kitapYayınevi = kitapYayınevi;
            this.kitapTur=kitapTur;
            this.adet=adet;
            this.sayfaSayısı = sayfasayısı;
            this.basımYılı = basımyılı;
        }



        public int getKitapId()
        {
            return this.kitapID;
        }
        public string getKitapAd()
        {
            return this.kitapAd;
        }
        public string getKitapYazar()
        {
            return this.kitapYazar;
        }
        public string getKitapDil()
        {
            return this.kitapDil;
        }
        public string getKitapYayınevi()
        {
            return this.kitapYazar;
        }
        public string getKitapTur()
        {
            return this.kitapTur;
        }
        public int getAdet()
        {
            return this.adet;
        }
        public int getSayfasayısı()
        {
            return this.sayfaSayısı;
        }
        public int getBasımYılı()
        {
            return this.basımYılı;
        }

    }
}
