using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            
            Console.Write("Please enter your name: ");
            string UserName = Console.ReadLine();
            return UserName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int FavNum = int.Parse(Console.ReadLine());
            return FavNum;
        }
        static int PromptUserBirthYear()
        {
            Console.Write("Please enter the year you were born: ");
            int BirthYear = int.Parse(Console.ReadLine());
            return BirthYear;
        }
        static void SquareNumber(int x, string UserName)
        {
            Console.WriteLine($"{UserName}, the square of your number is {x*x}.");
        }
        static void DisplayResult(int x, string UserName)
        {
            int CurrentYear = 2026;
            Console.WriteLine($"{UserName}, you will turn {CurrentYear - x} this year.");
        }
        DisplayWelcome();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        int BirthYear = PromptUserBirthYear();
        SquareNumber(Number, Name);
        DisplayResult(BirthYear, Name);
    }
}