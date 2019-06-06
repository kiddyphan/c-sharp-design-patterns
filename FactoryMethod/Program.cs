using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLogger = new FileLoggerFactory().createLogger();
            var consleLogger = new ConsoleLoggerFactory().createLogger();
            
            fileLogger.log();
            consleLogger.log();
        }
    }
}