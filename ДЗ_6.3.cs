using System;

class Program
{
    static int ReadNumber(int start, int end)
    {
        while (true)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= start && number <= end)
                {
                    return number;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"The number must be in the range [{start}...{end}].");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static void Main()
    {
        int previousNumber = 1;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Enter number {i}:");
            try
            {
                int number = ReadNumber(previousNumber, 100);
                if (number <= previousNumber)
                {
                    throw new Exception("The entered number must be greater than the previous number.");
                }
                previousNumber = number;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                i--;
            }
        }
    }
}