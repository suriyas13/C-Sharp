using System;
delegate int delename(int a, int b);
public class Eg
{
    public static int add(int a, int b)
    {
        Console.WriteLine("add");
        return a + b;
    }
    public int sub(int a, int b)
    {
        Console.WriteLine("sub");
        return a - b;
    }

    public static void Main(string[] args)
    {
        delename deleobj = new delename(add);
        int add1 = deleobj(10, 20);
        Console.WriteLine(add1);
        deleobj = new delename(new Eg().sub);
        int sub1 = deleobj(20, 10);
        Console.WriteLine(sub1);

    }
}
