namespace Strategy
{
    public class Eggs
    {
        private ICookStrategy _strategy;

        public Eggs(ICookStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Cook()
        {
            _strategy.Cook();
        }
    }
}