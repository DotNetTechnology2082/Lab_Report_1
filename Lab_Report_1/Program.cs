using System;

class Employee
{
    // Data members
    public int ID;
    public string Name;
    public double Salary;

    // Method to display employee details
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
        // Creating object of Employee class
        Employee emp = new Employee();

        // Assigning values
        emp.ID = 101;
        emp.Name = "Shudhansu Shah";
        emp.Salary = 100000;

        // Displaying employee details
        emp.Display();
    }
}