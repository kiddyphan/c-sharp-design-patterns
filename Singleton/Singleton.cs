namespace Singleton
{
    public class Singleton
    {
        static Singleton _instance;

        private Singleton()
        {
        }

        public static Singleton getInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}