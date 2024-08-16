using System;

namespace BuiltInException
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 45, 34, 67, 34 };
            int i;
            try
            {
                for (i = 0; i < 6; i++)
                    Console.WriteLine(" A[{0}] = {1}", i, a[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Out of Range Exception Raised");
            }
        }
    }
}