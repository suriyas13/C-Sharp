using System;
namespace operatorOverloading
{
    class num
    {
        private int x;
        public num()
        { }
        public num(int i)
        {
            x = i;
        }
        public void Show()
        {
            Console.WriteLine("{0}", x);
        }
        public static num operator +(num n1, num n2)
        {
            num t = new num();
            t.x = n1.x + n2.x;
            return t;
        }
        public static num operator -(num n1, num n2)
        {
            num t = new num();
            t.x = n1.x - n2.x;
            return t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            num n1 = new num(20);
            num n2 = new num(5);
            num n3 = new num();
            num n4 = new num();
            n3 = n1 + n2;
            n4 = n1 - n2;
            Console.Write("N1.X = ");
            n1.Show();
            Console.Write("N2.X = ");
            n2.Show();
            Console.Write("N3.X = ");
            n3.Show();
            Console.Write("N4.X = ");
            n4.Show();
        }
    }
}