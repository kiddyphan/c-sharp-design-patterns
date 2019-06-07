using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.getInstance();
            var singleton2 = Singleton.getInstance();

            if (singleton.Equals(singleton2))
            {
                Console.WriteLine("This is Singleton");
            }
            else
            {
                Console.WriteLine("This is not singleton");
            }
        }
    }
}