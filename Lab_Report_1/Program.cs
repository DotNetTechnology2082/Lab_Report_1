class Program
{
    static void Main()
    {
        Console.WriteLine("Enter student marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 40)
        {
            Console.WriteLine("Pass!!");
        }
        else
        {
            Console.WriteLine("Fail!!");
        }
    }
}