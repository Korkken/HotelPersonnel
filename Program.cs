// See https://aka.ms/new-console-template for more information
using HotelPersonnel;
using System.Xml.Linq;


Manager manager = new Manager(
    name: "Lisa Ledarsson",
    age: 40,
    employeeId: "M001",
    startDate: new DateTime(2020, 1, 1),
    salary: 50000,
    department: "Administration"
);

Employee employee = new Employee(
        name: "Erik Eriksson",
        age: 30,
        employeeId: "E001",
        startDate: new DateTime(2022, 3, 15),
        salary: 30000m,
        jobTitle: "Receptionist",
        department: "Front Desk"
);
Consultant consultant = new Consultant
(
    name:"Eva Expert",
    age: 35,
    employeeId: "C001",
    startDate: new DateTime(2023, 1, 1),
    salary: 0, // Konsulter har ofta inte fast lön
    hourlyRate: 1000,
    consultingFirm: "Hotell Experterna AB",
    expertise: "Hotelledare"
);


Console.WriteLine("Manager:");
manager.PrintInfo();
manager.Introduce();
manager.HoldMeeting();
manager.PlanBudget();

Console.WriteLine("\nEmployee:");
employee.PrintInfo();
employee.Introduce();
employee.Work();

Console.WriteLine("\nConsultant:");
consultant.PrintInfo();
consultant.Introduce();
consultant.GiveAdvice();
consultant.PayRate();

HouseKeeper anna = new HouseKeeper
    (
    name: "Anna Clean",
    age: 32,
    employeeId: "M001",
    startDate: new DateTime(2020, 1, 1),
    salary: 50000
    );
Console.WriteLine("\nHouseKeeper:");
anna.PrintInfo(); // Skriver ut namn och ålder
anna.Work(); // Skriver ut att Anna städar hotellrummen

public class Person
{
    public string Name { get; set; }
    public int Age  { get; set; }
    public string EmployeeId  { get; set; }
    public DateTime StartDate  { get; set; }
    public decimal Salary { get; set; }

    public Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
    {
        Name = name;
        Age = age;
        EmployeeId = employeeId;
        StartDate = startDate;
        Salary = salary;
    }


    public virtual void PrintInfo()
    {
        Console.WriteLine($"Namn: {Name}, Ålder {Age}");
    }
    public virtual void Introduce()
    {
        Console.WriteLine($"Hej, mitt namn är {Name} och jag är {Age} år gammal.");
    }
}


