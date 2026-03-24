class Employee
{
    // data members
    public int Id;
    public string Name;
    public int Salary;

    public string GetEmployeeDetails()
    {
        return $" Employee Details: \n Id: {Id}, Name: {Name}, Salary: {Salary}";
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Employee emp1 = new Employee();
        emp1.Id = 1;
        emp1.Name = "Suman Sunuwar";
        emp1.Salary = 50000;

        // Display employee details
        Console.WriteLine(emp1.GetEmployeeDetails());

        Employee emp2 = new Employee();
        emp2.Id = 2;
        emp2.Name = "Kalu Pandey";
        emp2.Salary = 40000;

        Console.WriteLine(emp2.GetEmployeeDetails());
    }
}