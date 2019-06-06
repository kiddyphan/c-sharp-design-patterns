namespace FactoryMethod
{
    public class FileLoggerFactory: LoggerAbstractFactory
    {
        public override ILogger createLogger()
        {
            return new FileLogger();
        }
    }
}