namespace FactoryMethod
{
    public class ConsoleLoggerFactory: LoggerAbstractFactory
    {
        public override ILogger createLogger()
        {
            return new ConsoleLogger();
        }
    }
}