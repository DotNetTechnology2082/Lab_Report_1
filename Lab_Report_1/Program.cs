using System;
class employee
{
    public int id;
    public string name;
    public double salary;

    public void dislayinfo()
    {
        Console.WriteLine("id is" + id);
        Console.WriteLine("name " + name);
        Console.WriteLine("salary is" + salary);
    }
}
class lab1
{
    static void Main(string[] args)
    {
        employee e = new employee();
        e.id = 32;
        e.name = "suvam kaji basnet";
        e.salary = 18000;

        e.dislayinfo();
    }
}