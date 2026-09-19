using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter;
        string subgrade = "";
        bool pass = false;
        if (percentage >= 90)
        {
            letter = "A";  
            pass = true;
        }
        else if (percentage >= 80 && percentage <90)
        {
            letter = "B";
            pass = true;
        }
        else if (percentage >= 70 && percentage <80)
        {
            letter = "C";
            pass = true;
        }
        else if (percentage >= 60 && percentage <70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage > 60 && percentage < 93)
        {
            if (percentage % 10 >= 7)
            {
                subgrade = "+";
            }
            else if (percentage % 10 < 3)
            {
                subgrade = "-";
            }
        }
        Console.WriteLine($"Your letter grade is {letter}{subgrade}");
        if (pass)
        {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else
        {
            Console.WriteLine("You can do better next time!");
        }
    }
}