using System;

class Employee
{
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
        Employee emp = new Employee();

        emp.ID = 201;
        emp.Name = "Tasi Sherpa";
        emp.Salary = 10000000;


        emp.Display();
    }
}