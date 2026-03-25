using System;

class Employee
{
    // Data members (fields / properties)
    public int ID { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    // Method to display employee details
    public void DisplayDetails()
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
        // Instantiate object of Employee class
        Employee emp1 = new Employee();

        // Assign values
        emp1.ID = 101;
        emp1.Name = "Anuj Bhattarai";
        emp1.Salary = 50000;

        // Display details
        emp1.DisplayDetails();
    }
}