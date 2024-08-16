using System;
namespace example
{
    class A
    {
        public static void Main(string[] args)
        {
            int i, j;
            int[] a = new int[7] { 102, 98, 100, 200, 100, 55, 145 };
            for (i = 0; i < 7; i++)
            {
                for (j = i + 1; j < 7; j++)
                {
                    if ((a[i] + a[j]) == 200)
                    {
                        Console.WriteLine("{0}+{1}= 200", a[i], a[j]);
                    }
                }
            }
        }
    }
}