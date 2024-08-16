using System;
class calculator
{
    public double add(double a, double b)
    {
        return a + b;
    }
    public double subtract(double a, double b)
    {
        return a - b;
    }
    public double multiply(double a, double b)
    {
        return a * b;
    }
    public double divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error");
            return double.NaN;
        }
        else
        {
            return a / b;
        }

    }

}
class Program
{
    public static void Main(string[] args)
    {
        calculator obj = new calculator();
        Console.WriteLine("Enter the numbers a and b:");

    }
}