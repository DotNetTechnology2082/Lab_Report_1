using System;

namespace EmployeeDemo
{
    // Define the Employee class
    class Employee
    {
        // Data members (fields)
        public int ID;
        public string Name;
        public double Salary;

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Employee class
            Employee emp1 = new Employee();

            // Initialize object data
            emp1.ID = 101;
            emp1.Name = "Beeraj Bhandari";
            emp1.Salary = 55000.50;

            // Display the employee details
            emp1.DisplayDetails();

            Console.ReadLine();
        }
    }
}

