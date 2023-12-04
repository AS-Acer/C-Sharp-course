using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcNumberchech
{
    public class tcno
    {
        private string tcNo;
        

        public string TCNumber {

            get
            {

                return tcNo.Substring(0,4);
            }
            set 
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for(int i=0; i <= value.Length; i++)
                    {
                        bool sayiMı = char.IsNumber(value[i]);
                        if (sayiMı)
                        {
                            //sayıysa bir şey yapmıyoruz
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                }
                if (kontrol)
                {
                    Console.WriteLine("Hata! TC kimlik numaranızda geçersiz karakter bulundu.");
                }
                else
                {
                    tcNo = value;
                }


            } 
        }

    }
}
