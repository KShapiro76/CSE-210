public class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;
    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    protected void MessageTimer(string message, int duration)
    {
       Console.Write(message);
       for (int i=duration; i>0; i--)
        {
            if (i!=duration)
            {
                Console.Write("\b");
            }
            Console.Write(String.Concat(i));
            Thread.Sleep(1000);
            if (i==1)
            {
                Console.Write("\b ");
            }
        }
    }
    protected void ShowPauseAnimation(int cycles=0)
    {
        for (int j=0; j<=cycles; j++)
        {
            if (j!=0)
            {
                Console.Write("\b\b\b\b\b");
            }
            for (int i=0; i<=1; i++)
            {
                if (i!=0)
                {
                    Console.Write("\b\b\b\b\b");
                }
                    Console.Write("|****");
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b*|***");
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b**|**");
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b***|*");
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b****|");
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b***|*");
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b**|**");
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b*|***");
                    Thread.Sleep(200);
                    if (i==1 && j==cycles)
                    {
                        Console.Write("\b\b\b\b\b|****" + "\n");

                    }
                    else if (i==1)
                    {
                        Console.Write("\b\b\b\b\b|****");
                    }
            }
        }
    }
    protected int GetDuration()
    {
        return _duration;
    }
    protected void InteractPrologue()
    {
        Console.WriteLine(_title + "\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long in seconds, would you like for this session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        ShowPauseAnimation();


    }
    protected void InteractEpilogue()
    {
        Console.WriteLine("Well Done!!");
        ShowPauseAnimation();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title}.");
        ShowPauseAnimation();
    }
}