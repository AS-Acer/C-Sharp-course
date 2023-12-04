using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticYapıcıMetod
{
    internal class eleman
    {
        private int elemanId;
        private string name;
        private string surname;
        private string description;
        private static int maas;




        static eleman()
        {
            maas = 2500;  
        
        }

        public eleman(int elamanID,string names,string surnames, string descriptions)
        {
            elemanId = elamanID;
            name = names;
            surname = surnames;
            description = descriptions;

        }

        public void information()
        {
            Console.WriteLine("Eleman Bilgileri : ");
            Console.WriteLine("Elemanınızın Id'si : "+elemanId);
            Console.WriteLine("Elemanınızın ismi : " + name);
            Console.WriteLine("Elemanınızın soyismi : "+ surname);
            Console.WriteLine("Elemanınız hakkında : "+ description);
            Console.WriteLine("Maaş bilgisi : "+ maas);
            
        }

        public void zamYap(int eklencekMiktar)
        {
            Console.WriteLine("Elamana zam yaplıyor . . . ");
            Console.WriteLine("Yeni Maaş Miktarı : "+ (maas+ eklencekMiktar));
        }


    }
}
