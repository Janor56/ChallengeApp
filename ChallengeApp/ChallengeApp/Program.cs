using ChallengeApp;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Adam", "Mickiewicz", 30);
Employee employee2 = new Employee("Anna", "Nowak", 35);
Employee employee3 = new Employee("Jan", "Kowalski", 45);

employee1.AddGrade(7);
employee1.AddGrade(9);
employee1.AddGrade(10);
employee1.AddGrade(5);
employee1.AddGrade(7);

employee2.AddGrade(3);
employee2.AddGrade(9);
employee2.AddGrade(9);
employee2.AddGrade(8);
employee2.AddGrade(10);

employee3.AddGrade(7);
employee3.AddGrade(6);
employee3.AddGrade(7);
employee3.AddGrade(2);
employee3.AddGrade(9);

var employee1Result = employee1.result;
var employee2Result = employee2.result;
var employee3Result = employee3.result;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.result;
    }
};

Console.WriteLine("Najlepszy pracownik to " + employeeWithMaxResult.name + " " + employeeWithMaxResult.surname+", Wiek: "+employeeWithMaxResult.age);
Console.WriteLine("Wynik najlepszego pracownika wynosi: " + employeeWithMaxResult.result);