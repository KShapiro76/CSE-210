using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math215 = new MathAssignment("Kaydon Shapiro", "Multivariable Calculus", "Section 2.1", "3-11");
        Console.WriteLine(math215.GetSummary());
        Console.WriteLine(math215.GetHomeworkList());

        WritingAssignment Eng150 = new WritingAssignment("Jeremy Wales", "English 150", "Mary Had a Little Lamb");
        Console.WriteLine(Eng150.GetSummary());
        Console.WriteLine(Eng150.GetWritingInformation());
    }
}