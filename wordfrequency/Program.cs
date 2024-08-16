using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of n:");
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        Console.WriteLine($"Enter {n} strings:");

        for (int i = 0; i < n; i++)
        {
            string[] words = Console.ReadLine().Split(' ');

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }
        }

        var sortedWords = wordFrequency.OrderByDescending(pair => pair.Value);

        Console.WriteLine("\nFrequently occurred words in descending order:");

        foreach (var pair in sortedWords)
        {
            Console.Write(pair.Key + " ");
        }
    }
}
