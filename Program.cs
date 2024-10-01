// See https://aka.ms/new-console-template for more information
using HotelPersonnel;
using System.Xml.Linq;


HotelStaff();
StaffWork();


void HotelStaff()
{
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
),
    new HouseKeeper
    (
        name: "Anna clean",
        age: 32,
        employeeId: "D001",
        startDate: new DateTime(2022, 1, 2),
        salary: 30000
        )
];


    Console.WriteLine("Hotellets personal:");
    foreach (var person in hotelStaff)
    {
        person.PrintInfo();
        person.Introduce();
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
}
void StaffWork()
{
    List<Person> staff = new List<Person>();

    staff.Add(new Manager("Lisa Ledarsson", 40, "M001", new DateTime(2020, 1, 1), 50000, "Administration"));
    staff.Add(new Employee("Erik Eriksson", 30, "E001", new DateTime(2022, 3, 15), 30000, "Receptionist", "Front Desk"));
    staff.Add(new Consultant("Eva Expert", 35, 1000, "Hotell Experterna AB", "C001", new DateTime(2023, 1, 1), 0, "Hotelledare"));
    staff.Add(new HouseKeeper("Anna clean", 32, "D001", new DateTime(2022, 1, 2), 30000));

    foreach (Person person in staff)
    {
        person.DoWork();
    }
}
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



