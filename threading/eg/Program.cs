using System;
using System.Threading;
namespace suriya
{
    class Eg
    {
        public void first()
        {
            Console.WriteLine("First method started");
            Thread.Sleep(1000);
            Console.WriteLine("First method Ended");
        }
        public void Second()
        {
            Console.WriteLine("Second method started");
            Thread.Sleep(1000);
            Console.WriteLine("Second method Ended");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Eg obj = new Eg();
            Thread t1 = new Thread(new ThreadStart(obj.first));
            Console.WriteLine("Thread 1 started");
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(obj.Second));
            Console.WriteLine("Thread 2 started");
            t2.Start();
        }
    }
}