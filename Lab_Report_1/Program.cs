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
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        
        emp.ID = 101;
        emp.Name = "John Doe";
        emp.Salary = 50000;
        
        emp.Display();

        Console.ReadLine();
    }
}