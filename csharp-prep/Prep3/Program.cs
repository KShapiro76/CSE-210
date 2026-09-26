using System;

class Program
{
    static void Main(string[] args)
    {
        string MagicNum = "";
        string GuessNum = "";
        Console.Write("What is the magic number? ");
            MagicNum = Console.ReadLine();
        do
        {
            Console.Write("What is your guess? ");
            GuessNum = Console.ReadLine();
            if (int.Parse(GuessNum) < int.Parse(MagicNum))
            {
                Console.WriteLine("Higher");
            }
            else if (int.Parse(GuessNum) > int.Parse(MagicNum))
            {
                Console.WriteLine("Lower");
            }


        } while (MagicNum != GuessNum);
        Console.WriteLine("You guessed it!");
    }
}