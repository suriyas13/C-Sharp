using System;
namespace MyApplication
{
    public class Shape
    {
        public void draw()
        {
            Console.WriteLine("drawing shapes...");
        }
    }
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            Shape s;
            s = new Rectangle();
            s.draw();
        }
    }
}
