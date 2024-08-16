using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the limit for Fibonacci series:");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = FibonacciSum(n);
        Console.WriteLine($"Sum of Fibonacci series is {sum}");
    }

    static int FibonacciSum(int n)
    {
        int sum = 0;
        int a = 0;
        int b = 1;
        int c = 0;

        for (int i = 1; i <=n; i++)
        {
            sum += a; 
            c = a + b;
            a = b;
            b = c;
        }

        return sum;
    }
}
