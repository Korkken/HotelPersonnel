using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelPersonnel
{
    internal class Manager : Person
    {
        public string Department { get; set; }

        public Manager(string name, int age, string employeeId, DateTime startDate, decimal salary, string department)
            : base(name, age, employeeId, startDate, salary)
        {

            Department = department;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
        public override void Introduce()
        {
            base.Introduce();
        }
        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} Håller ett personalmöte på hotellet");
        }
        public void PlanBudget()
        {
            Console.WriteLine($"{Name} Planerar budget för hotellet");
        }
        public override void DoWork()
        {
            Console.WriteLine($"{Name} håller på att planera och leda i Lyx svit avdelningen");
        }
        public override void CalculateYearsOfService()
        {
            base.CalculateYearsOfService();
        }
    }
}
