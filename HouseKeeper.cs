using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelPersonnel
{
    public class HouseKeeper
    {
        private Person _person;
        public string Name;
        public int Age;


        public HouseKeeper(string name, int age)
        {
            _person = new Person(name, age, null, DateTime.Now, 0);
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            _person.PrintInfo();
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is cleaning the hotel rooms.");
        }
    }
}
