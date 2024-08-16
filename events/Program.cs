using System;
namespace Delegates_and_events
{
    public delegate void smvec();
    class Program
    {
        public static event smvec sports;

        static void cricket()
        {
            Console.WriteLine("CSE Department is a winner");
        }
        static void football()
        {
            Console.WriteLine("IT Department is a winner");
        }

        static void Main(string[] args)
        {
            sports += new smvec(cricket);
            sports += new smvec(football);

            sports.Invoke();

        }

    }
}