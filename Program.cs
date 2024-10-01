// See https://aka.ms/new-console-template for more information
using HotelPersonnel;
using System.Xml.Linq;

List<Person> hotelStaff =
[
    new Manager(
        name: "Lisa Ledarsson",
        age: 40,
        employeeId: "M001",
        startDate: new DateTime(2020, 1, 1),
        salary: 50000,
        department: "Administration"
),
    new Employee(
            name: "Erik Eriksson",
            age: 30,
            employeeId: "E001",
            startDate: new DateTime(2022, 3, 15),
            salary: 30000m,
            jobTitle: "Receptionist",
            department: "Front Desk"
),
    new Consultant
(
        name:"Eva Expert",
        age: 35,
        employeeId: "C001",
        startDate: new DateTime(2023, 1, 1),
        salary: 0,
        hourlyRate: 1000,
        consultingFirm: "Hotell Experterna AB",
        expertise: "Hotelledare"
)
];


Console.WriteLine("Hotellets personal:");
foreach (var person in hotelStaff)
{
    person.PrintInfo();
    person.Introduce();
    person.DoWork();
    if (person is Manager manager)
    {
        manager.HoldMeeting();
    }
    else if (person is Employee employee)
    {
        employee.Work();
    }
    else if (person is Consultant consultant)
    {
        consultant.GiveAdvice();
    }

    Console.WriteLine();
}

double averageAge = hotelStaff.Average(p => p.Age);
decimal totalSalary = hotelStaff.Sum(p => p.Salary);

Console.WriteLine($"Genomsnittlig ålder på personalen: {averageAge:F1} år");
Console.WriteLine($"Total månadslön för anställda: {totalSalary:C}");

HouseKeeper anna = new HouseKeeper(name: "Anna Clean", age: 32);
Console.WriteLine("\nHouseKeeper:");
anna.PrintInfo();
anna.Work(); 

public class Person
{
    public string Name;
    public int Age;
    public string EmployeeId;
    public DateTime StartDate;
    public decimal Salary;

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
    public virtual void DoWork()
    {
        Console.WriteLine($"");
    }
}


