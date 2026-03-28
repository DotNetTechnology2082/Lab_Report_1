using System;

class Employee
{
    // Data members
    public int ID;
    public string Name;
    public double Salary;

    public void Display()
    {
        Console.WriteLine("Employee ID: " + ID);
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Salary: " + Salary);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // Creating object of Employee class
        Employee emp = new Employee();

        emp.ID = 101;
        emp.Name = "Pasang Lama";
        emp.Salary = 50000;

        emp.Display();
    }
}