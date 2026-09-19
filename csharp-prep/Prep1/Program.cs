using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        string firstname = "What is your first name? ";
        Console.Write(firstname);
        firstname = Console.ReadLine();

        string lastname = "What is your last name? ";
        Console.Write(lastname);
        lastname = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }



}