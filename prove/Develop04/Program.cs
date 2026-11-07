using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int response;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = int.Parse(Console.ReadLine());


            if (response == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.InteractBreathing();
            }
            if (response == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.InteractReflection();
            }
            if (response == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.InteractListing();
            }

        } while (response != 4);
    }
}