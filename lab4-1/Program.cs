using System;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            username user = new username();
            user.getName();
            user.displayUsernames();
        }
    }

    class username
{
    private string first;
    private string last;

    public void getName()
    {
        Console.Write("Enter your first name: ");
        first = Console.ReadLine();
        Console.Write("Enter your last name: ");
        last = Console.ReadLine();
    }
    public void displayUsernames()
    {
        Console.WriteLine("These usernames are available: ");
        Console.WriteLine(first + last);
        Console.WriteLine(last + first);
        Console.WriteLine(first + " " + last);
        Console.WriteLine(last + "-" + first);
    }
}
}
