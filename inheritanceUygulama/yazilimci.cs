using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceUygulama
{
    public class yazilimci : calisan
    {
        private string diller;
        public yazilimci(int id,string name,string surname,int maas,string diller):base(id,name,surname,maas)
        {
            this.diller = diller;
        }

        public void formatAt(string işletimSistemi)
        {
            Console.WriteLine(getName()+" şuanda "+işletimSistemi+ " işletim sistemine format atıyor .. .. ..");
        }
    }
}
