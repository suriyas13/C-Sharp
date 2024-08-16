using System;
namespace pointer;
class PrintASCII
{
    public static void Main(String[] args)
    {
        char[] arr = new char[20];
        int i;
        for (i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToChar(65 + i);
        }
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
