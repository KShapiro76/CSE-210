using System;
using System.IO.Enumeration;
using System.Net;
class Program
{
    static string GetFilePath()
    {
        Console.WriteLine("What is the filename");
        string fileName = Console.ReadLine();
        string projectFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../.."));
        return Path.Combine(projectFolder, "Develop02", fileName);
    }
    
    static void Main(string[] args)
    {
        string Response = "";
        List<string> Prompts = new List<string> 
            {
                "Who was the most interesting person I interacted with today?", 
                "What was the best part of my day?", 
                "How did I see the hand of the Lord in my life today?", 
                "What was the strongest emotion I felt today?", 
                "If I had one thing I could do over today, what would it be?"
            };
        Journal journal1 = new Journal();
        while (Response != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Response = Console.ReadLine();

            if (Response == "1")
            {
                journal1.AddEntry(Prompts);
            }
            if (Response == "2")
            {
                journal1.Display();
            }
            if (Response == "3")
            {
                journal1.LoadFromFile(GetFilePath());
            }
            if (Response == "4")
            {
                
                journal1.SaveToFile(GetFilePath());
            }

        }
    }
}