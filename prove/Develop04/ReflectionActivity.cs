using System.Security.Cryptography;

public class ReflectionActivity : Activity
{
    private List<Prompt> _primaryPrompts = [
        new Prompt("Think of a time when you stood up for someone else."),
            new Prompt("Think of a time when you did something really difficult."),
            new Prompt("Think of a time when you helped someone in need."),
            new Prompt("Think of a time when you did something truly selfless.")
    ];
    private List<Prompt> _secondaryPrompts = [
        new Prompt("Why was this experience meaningful to you?"),
            new Prompt("Have you ever done anything like this before?"),
            new Prompt("How did you get started?"),
            new Prompt("How did you feel when it was complete?"),
            new Prompt("What made this time different than other times when you were not as successful?"),
            new Prompt("What is your favorite thing about this experience?"),
            new Prompt("What could you learn from this experience that applies to other situations?"),
            new Prompt("What did you learn about yourself through this experience?"),
            new Prompt("How can you keep this experience in mind in the future?")
    ];
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}
    public void InteractReflection()
    {
        InteractPrologue();
        Console.WriteLine("Consider the following Prompt:");
        Random rand1 = new Random();
        int randIndex = rand1.Next(0, _primaryPrompts.Count);
        Console.Write(" --- ");
        Console.Write(_primaryPrompts[randIndex].GetText());
        _primaryPrompts[randIndex].SelectOrDeselect();
        Console.Write(" ---");
        Console.WriteLine("\n\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        MessageTimer("You may begin in: ", 5);
        Console.WriteLine("\n");

        Random rand2 = new Random();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now;
        while (futureTime > currentTime)
        {
            randIndex = rand2.Next(0, _secondaryPrompts.Count);
            
            Console.Write(" > ");
            Console.Write(_secondaryPrompts[randIndex].GetText() + " ");
            _secondaryPrompts[randIndex].SelectOrDeselect();
            ShowPauseAnimation(3);
            
            currentTime = DateTime.Now;
        }
        InteractEpilogue();
    }

}