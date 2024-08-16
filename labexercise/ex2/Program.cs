using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(new ThreadStart(ExampleFunction));
        thread.Start();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main thread executing: " + i);
            Thread.Sleep(2000);
        }

        thread.Join();

        Console.WriteLine("Main thread exiting.");
    }

    static void ExampleFunction()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Thread function executing: " + i);
            Thread.Sleep(2000);
        }
        Console.WriteLine("Thread function exiting.");
    }
}

