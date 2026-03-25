using System;

class Employee
{
    public int ID;
    public string Name;
    public double Salary;

    public void Display()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        emp.ID = 11;
        emp.Name = "Krishal";
        emp.Salary = 30000;

        emp.Display();

        Console.ReadLine();
    }
}