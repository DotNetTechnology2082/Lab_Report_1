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
        emp.Name = "John Doe";
        emp.Salary = 50000;

        // Displaying details
        emp.Display();

        Console.ReadLine();
    }
}