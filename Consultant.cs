using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HotelPersonnel
{
    class Consultant : Person
    {
        public decimal HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public string Expertise { get; set; }
        public Consultant(string name, int age, decimal hourlyRate, string consultingFirm, string employeeId, DateTime startDate, int salary, string expertise)
            : base(name, age, employeeId, startDate, salary)
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
            Expertise = expertise;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
        public override void Introduce()
        {
            base.Introduce();
        }
        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} ger råd till hotellet om hur de kan förbättra sina rutiner inom området {Expertise}");
        }
        public void PayRate()
        {
            Console.WriteLine($"Hourly Rate: {HourlyRate}");
            Console.WriteLine($"Consulting Firm: {ConsultingFirm}");
        }
        public override void DoWork()
        {
            Console.WriteLine($"{Name} arbetar med {Expertise}");
        }
    }
}
