using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedenKitleEndeksü
{
    public class persons
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public  int weight { get; set; }
        public double tall { get; set; }
        public string indeks { get; set; }

        
            
        public persons()
        {
        
        }

        public persons(int id,string name,string surname,int weight,double tall,string endeks) { 
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.weight = weight;
            this.tall = tall;
            this.indeks = endeks;
          
        }

        public int getId()
        {
            return id;
        } 
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name= name;
        }
        public string getSurname()
        {
            return surname;
        }
        public void setSurname(string surname)
        {
            this.surname= surname;
        }
        public int getWeight()
        {
            return weight;
        }
        public void setWeight(int weight)
        {
            this.weight = weight;
        }
        public double getTall()
        {
            return tall;
        }
        public void setTall(double tall)
        {
            this.tall = tall;
        }
        public string getİndeks()
        {
            return indeks;

        }
        public void setİndeks(string indeks)
        {
            this.indeks = indeks;
        }
    

        
    }
}
