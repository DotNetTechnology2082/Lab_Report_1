using static System.Runtime.InteropServices.JavaScript.JSType;

//Write a C# program to define a class Employee with data members (ID, Name, Salary). Create an object of the class and display the employee details.

//To understand the concept of

//To create a class with data members

//To instantiate an object and display data

//To use GitHub for version control (clone, branch, push)
//Console.WriteLine("Hello, World!");


using System;

namespace EmployeeApp
{
    // Define the Employee class
    class Employee
    {
        // Data members
        public int ID;
        public string Name;
        public double Salary;

        // Constructor
        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

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
            // Create an object of Employee
            Employee emp = new Employee(101, "pradip", 50000);

            // Display employee details
            emp.DisplayDetails();

            Console.ReadLine();
        }
    }
}


