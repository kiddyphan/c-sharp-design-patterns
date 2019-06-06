using System;

namespace FactoryMethod
{
    public class ConsoleLogger: ILogger
    {
        public void log()
        {
            Console.WriteLine("Logging using Console.WriteLine");
        }
    }
}