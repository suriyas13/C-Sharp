using System;
namespace mutipleinheritance
{
    interface Base1
    {
        public void printbase1();
    }
    interface Base2
    {
        public void printbase2();
    }
    class A : Base1, Base2
    {
        public void printbase1()
        {
            Console.WriteLine("Base1");
        }
        public void printbase2()
        {
            Console.WriteLine("Base2");
        }
        public void printA()
        {
            Console.WriteLine("A class");
        }
    }
    class B
    {
        public static void Main(string[] args)
        {
            A obj = new A();
            obj.printbase1();
            obj.printbase2();
            obj.printA();
        }
    }
}
