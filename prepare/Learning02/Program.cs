using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._JobTitle = "Electrical Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2028;
        job1._endYear = 2032;
        job1.Display();
        Job job2 = new Job();
        job2._JobTitle = "Telecommunications Engineer";
        job2._company = "Apple";
        job2._startYear = 2032;
        job2._endYear = 2040;
        Resume Resume1 = new Resume();
        Resume1._name = "Kaydon Shapiro";
        Resume1._jobs.Add(job1);
        Resume1._jobs.Add(job2);
        Resume1.Display();
    }
}