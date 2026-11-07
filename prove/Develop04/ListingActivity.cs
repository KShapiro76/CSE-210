public class ListingActivity : Activity
{
    List<Prompt> _listingPrompts = [
        new Prompt("Who are people that you appreciate?"),
        new Prompt("What are personal strengths of yours?"),
        new Prompt("Who are people that you have helped this week?"),
        new Prompt("When have you felt the Holy Ghost this month?"),
        new Prompt("Who are some of your personal heroes?")
        ];
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}
    public void InteractListing()
    {
        InteractPrologue();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Random rand = new Random();
        Console.Write(" --- ");
        Console.Write(_listingPrompts[rand.Next(0, _listingPrompts.Count)].GetText());
        Console.Write(" --- ");
        Console.WriteLine("\n");
        MessageTimer("You may begin in: ", 5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now;
        while (futureTime > currentTime)
        {
            Console.Write(" > ");
            Console.ReadLine();

            currentTime = DateTime.Now;
        }
        InteractEpilogue();
    }
    
}