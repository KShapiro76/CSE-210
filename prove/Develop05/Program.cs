using System;

class Program
{
    static void Main(string[] args)
    {
        GoalList Goals = new GoalList();
        Console.Clear();
        do
        {       
        Console.WriteLine($"You have {Goals.GetCumulativeScore()} points.\n");
        Console.WriteLine("Menu options:");
        Console.WriteLine("  1. Create new Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Exit\n");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Goals.CreateGoal();
                Console.Clear();
                break;
            case "2":
                Console.Clear();
                Goals.DisplayList();
                break;
            case "3":
                Goals.SavetoFile();
                Console.Clear();
                break;
            case "4":
                Goals.LoadFromFile();
                Console.Clear();
                break;
            case "5":
                Goals.RecordEvent();
                Console.Clear();
                break;
            case "6":
                Console.WriteLine("Exiting");
                return;
            default:
                Console.WriteLine("Invalid input. Please try again.");
                Thread.Sleep(1000);
                break;
        }
        } while (true);




    
    }
}