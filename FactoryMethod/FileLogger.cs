using System;

namespace FactoryMethod
{
    public class FileLogger: ILogger
    {
        public void log()
        {
            Console.WriteLine("Logging using StreamWriter");
        }
    }
}