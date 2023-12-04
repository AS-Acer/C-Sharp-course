using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceUygulama
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz");

            Console.WriteLine("1- Yazılımcı işlemleri ");
            Console.WriteLine("2-Yönetici işlemleri ");
            Console.WriteLine("Çıkış yapmak için q'ya basın.");

            string kullanıcıislemsecimi = Console.ReadLine();

            while (true)
            {
                if (kullanıcıislemsecimi == "q")
                {
                    Console.WriteLine("Çıkış yapılıyor .. .. .. ");
                    break;
                }
                else if (kullanıcıislemsecimi == "1")
                {
                    yazilimci amet = new yazilimci(1, "Ahmet", "Acer", 40000, "c# ,dart , javascript");
                    Console.WriteLine("Yazılımcı işlemlerinde hoşgeldiniz ");
                    Console.WriteLine("1-Format at");
                    Console.WriteLine("2-Yazılımcı bilgilerini göster ");
                    Console.WriteLine("3-Çıkış için q'ya basınız");
                    string yazilimciislem = Console.ReadLine();

                    while (true)
                    {

                        if (yazilimciislem == "q")
                        {
                            Console.WriteLine("Çıkış yapılıyor...");
                            break;
                        }
                        else if (yazilimciislem == "1")
                        {
                            Console.Write("İşletim sistemi giriniz : ");
                            string isletimSistemi = Console.ReadLine();
                            amet.formatAt(isletimSistemi);
                            break;
                        }
                        else if (yazilimciislem == "2")
                        {
                            amet.bilgileriGoster();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yazılımcı işlemleri için geçerli işlem  numarası giriniz ");
                            break;
                        }

                    }
                }

                else if (kullanıcıislemsecimi == "2")
                {

                    yonetici said = new yonetici(2, "Said", "Acer", 546458, 15);
                    Console.WriteLine("Yönetici işlemlerinde hoşgeldiniz ");
                    Console.WriteLine("1-Zam yap");
                    Console.WriteLine("2-Yönetici bilgilerini göster ");
                    Console.WriteLine("3-Çıkış için q'ya basınız");
                    string yoneticiIslem = Console.ReadLine();

                    while (true)
                    {


                        if (yoneticiIslem == "q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor...");
                            break;

                        }
                        else if (yoneticiIslem == "1")
                        {
                            Console.WriteLine("Zam miktarı giriniz : ");
                            int zamMiktarı = Convert.ToInt32(Console.ReadLine());
                            said.zamyap(zamMiktarı);
                            break;

                        }
                        else if (yoneticiIslem == "2")
                        {
                            said.bilgileriGoster();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yönetici işlemleri için lütfen geçerli bir değer giriniz !");
                            break;
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                    break;
                }


            }

        }
    }
}
