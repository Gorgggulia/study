using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, -10, 15, -20, 25, -30, 35, -40, 45, -50 };

        Console.WriteLine("Negative numbers:");
        var negativeNumbers = numbers.Where(n => n < 0);
        foreach (var number in negativeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nPositive numbers:");
        var positiveNumbers = numbers.Where(n => n > 0);
        foreach (var number in positiveNumbers)
        {
            Console.WriteLine(number);
        }

        int largest = numbers.Max();
        int smallest = numbers.Min();
        int sum = numbers.Sum();

        Console.WriteLine($"\nLargest element: {largest}");
        Console.WriteLine($"Smallest element: {smallest}");
        Console.WriteLine($"Sum of all elements: {sum}");

        double average = numbers.Average();
        int firstLargestBelowAverage = numbers.Where(n => n < average).OrderByDescending(n => n).FirstOrDefault();

        Console.WriteLine($"\nFirst largest element below average: {firstLargestBelowAverage}");

        Array.Sort(numbers);

        Console.WriteLine("\nSorted array:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}