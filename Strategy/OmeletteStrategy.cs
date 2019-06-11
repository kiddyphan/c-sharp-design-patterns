using System;

namespace Strategy
{
    public class OmeletteStrategy : ICookStrategy
    {
        public void Cook()
        {
            Console.WriteLine("Eggs has been cooked via: Omelette Strategy");
        }
    }
}