public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}
    public void InteractBreathing()
    {
        InteractPrologue();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now;
        while (futureTime > currentTime)
        {
            MessageTimer("Breathe In... ", 4);
            MessageTimer("\nBreathe Out... ", 6);
            Console.WriteLine("\n");

            currentTime = DateTime.Now;
        }
        InteractEpilogue();
    }
}