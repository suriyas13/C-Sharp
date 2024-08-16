using System;
namespace EG
{
    class getstring
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ENter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            string s;
            Console.WriteLine("ENter a name:");
            s = Console.ReadLine();
            Console.WriteLine("num" + n + "name" + s);

        }
    }
}