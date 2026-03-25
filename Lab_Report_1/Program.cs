// Write a C# program to define a class Employee with data members (ID, Name, Salary).
// Create an object of the class and display the employee details.
using System; 
// is used to include the System namespace in a C# program, which provides basic classes like Console, String, Math, etc.
class Employee { 
    public int id;
    public string name;
    public double salary;

    public Employee(int id, string name, double salary) { 
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public void EmployeeDetails() { 
        Console.WriteLine($"Id: {id}, Name: {name}, Salary: Rs {salary}");  
    }
}
class Program { 
    public static void Main(string[] args) { 
        Employee emp = new Employee(1, "Anmol", 50000);
        emp.EmployeeDetails();
    }
}
