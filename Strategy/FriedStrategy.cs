using System;

namespace Strategy
{
    public class FriedStrategy : ICookStrategy
    {
        public void Cook()
        {
            Console.WriteLine("Eggs has been cooked via: Fried Strategy");
        }
    }
}