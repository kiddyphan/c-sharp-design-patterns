using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var omeletteEggs = new Eggs(new OmeletteStrategy());
            omeletteEggs.Cook();
            
            var friedEggs = new Eggs(new FriedStrategy());
            friedEggs.Cook();
            
            var boiledEggs = new Eggs(new BoiledStrategy());
            boiledEggs.Cook();
        }
    }
}