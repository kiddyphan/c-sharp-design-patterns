using System;

namespace Strategy
{
    public class BoiledStrategy : ICookStrategy
    {
        public void Cook()
        {
            Console.WriteLine("Eggs has been cooked via: Boiled Strategy");
        }
    }
}