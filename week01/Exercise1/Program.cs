using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fname;
        fname = Console.ReadLine();
        Console.Write("What is your Last name? ");
        string lname;
        lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}