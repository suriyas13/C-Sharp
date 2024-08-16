using System;

class LexicographicalSort
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the number of strings:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }

            string[] strings = new string[n];

            Console.WriteLine("Enter the strings:");

            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            Array.Sort(strings);

            Console.WriteLine("\nSorted strings:");

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number entered is too large.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
