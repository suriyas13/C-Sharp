using System;
namespace Pro
{
    class Function
    {
        void arrayprint(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 5, 4, 3, 6, 3, 8, 7, 9 };
            Function obj = new Function();
            obj.arrayprint(arr);
        }
    }
}