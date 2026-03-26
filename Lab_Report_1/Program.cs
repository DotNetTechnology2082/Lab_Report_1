//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter student marks:");
//            int marks = Convert.ToInt32(Console.ReadLine());

//        if (marks >= 50)
//        {
//            Console.WriteLine("Pass");
//        }
//        else
//        {
//            Console.WriteLine("Fail");
//        }
//    }
//}
using System;

class Employee
{
    public int ID;
    public string Name;
    public double Salary;

    public void Display()
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
        Employee emp = new Employee();

        emp.ID = 21;
        emp.Name = "Pradip Prajapati";
        emp.Salary = 30000;

        emp.Display();

        Console.ReadLine();
    }
}