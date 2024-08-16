using System;
class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double harmonicMean = CalculateHarmonicMean(num1, num2);

                Console.WriteLine($"The harmonic mean of {num1} and {num2} is: {harmonicMean}");
    }
    static double CalculateHarmonicMean(double num1, double num2)
    {
                return 2 / (1 / num1 + 1 / num2);
    }
}
