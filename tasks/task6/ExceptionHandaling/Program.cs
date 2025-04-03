using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            List<int> numbers = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine()); 

                if (numbers.Contains(number))
                {
                    throw new InvalidOperationException($"Duplicate number detected: {number}");
                }

                numbers.Add(number);
            }

            Console.WriteLine("Numbers entered: " + string.Join(", ", numbers));
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Please enter only valid integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}