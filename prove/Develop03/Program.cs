using System;

class Program
{
    static void Main(string[] args)
    {
        
        ScriptureBank bank = new ScriptureBank();
        Scripture memorizeScripture1 = bank.GetRandomScripture();
        int i = 0;
        do
        {
            Console.Clear();
            if (i > 0)
            {
                memorizeScripture1.HideThree();
            }
            i++;
            memorizeScripture1.Display();
            Console.WriteLine("\nPress enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
        } while (!memorizeScripture1.StatusAllHidden());
    }
}