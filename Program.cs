// See https://aka.ms/new-console-template for more information
using HotelPersonnel;
using System.ComponentModel;
using System.Xml.Linq;


HotelStaff();



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
    foreach (var person in hotelStaff)
    {
        person.DoWork();
    }
}





