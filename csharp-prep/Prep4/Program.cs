using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> NumList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int num;
        int Sum = 0;
        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            NumList.Add(num);
            
        } while (num != 0);
        foreach (int Number in NumList)
        {
            Sum += Number;
        }
        Console.WriteLine($"The sum is: {Sum}");
        float Average = Sum / (NumList.Count - 1);
        Console.WriteLine($"The average is: {Average}");
        int LargestNum = NumList[0];
        foreach (int Number in NumList)
        {
            if (Number > LargestNum && Number != 0)
            {
                LargestNum = Number;
            }
        }
        Console.WriteLine($"The largest number is: {LargestNum}");
        int BigNum = 0;
        foreach (int Number in NumList)
        {
            if (Number > BigNum)
            {
                BigNum = Number;
            }
        }
        int SmallestNum = BigNum;
        if (SmallestNum != 0)
        {
            foreach (int Number in NumList)
            {
                if (Number > 0 && Number/2 < SmallestNum/2)
                {
                    SmallestNum = Number;
                }
            }
            Console.WriteLine($"The smallest positive number is: {SmallestNum}");
        }
        else
        {
            Console.WriteLine("The smallest positive number is: None");
        }
        NumList.Sort();
        foreach (int Number in NumList)
        {
            if (Number != 0)
            {
                Console.WriteLine(Number);
            }
        }
    }
}