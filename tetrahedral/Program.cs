using System;
class Tetrahedral
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int t = (n * (n + 1) * (n + 2)) / 6;
        Console.WriteLine("Tetrahedral is {0}", t);

    }
}