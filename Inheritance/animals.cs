using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class animals_
    {
        public string animal_name;
        public int animal_age;
        public string animal_sex;
        public string animal_color;

        public void showInfo()
        {
            Console.WriteLine("Hayvanınızın adı : " +animal_name);
            Console.WriteLine("Hayvanınızın yaşı : " + animal_age);
            Console.WriteLine("Hayvanınızın cinsiyeti : " + animal_sex);
            Console.WriteLine("Hayvanınızın adı : " + animal_color);

           


        }

    }
}
