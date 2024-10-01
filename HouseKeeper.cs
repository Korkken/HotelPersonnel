using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelPersonnel
{
    internal class HouseKeeper : Person
    {
        public HouseKeeper(string name, int age, string employeeId, DateTime startDate, decimal salary)
            : base(name, age, employeeId, startDate, salary)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hej, mitt namn är {Name} och jag är {Age} år gammal.");
        }
        public override void DoWork()
        {
            Console.WriteLine($"{Name} Håller på att städa rummen");
        }
        public override void CalculateYearsOfService()
        {
            base.CalculateYearsOfService();
        }
    }
}
