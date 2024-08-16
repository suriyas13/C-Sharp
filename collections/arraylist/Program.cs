using System;
using System.Collections;
namespace eg
{
    class Arraylist
    {
        public static void Main(string[] args)
        {
            var arr = new ArrayList();
            arr.Add(1);
            arr.Add(2);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}