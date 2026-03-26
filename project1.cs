using System;

class Employee
{
    public int Id;
    public string Name;
    public double Salary;

    public Employee(int id, string name, double salary)
    {
        Id     = id;
        Name   = name;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine("----------------");
        Console.WriteLine($"ID     : {Id}");
        Console.WriteLine($"Name   : {Name}");
        Console.WriteLine($"Salary : {Salary:C}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee(101, "Anish Sharma", 75000);
        emp.Display();
    }
}
