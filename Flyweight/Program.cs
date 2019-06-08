using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeMachine = new CoffeeMachine();
            var coffeeShop =  new CoffeeShop(coffeMachine);
            
            coffeeShop.Order(1, "more milk");
            coffeeShop.Order(2, "more sugar");
            coffeeShop.Order(3, "less sugar");
            coffeeShop.Order(4, "less sugar");
            coffeeShop.Order(5, "more milk");
            
            coffeeShop.Serve();
            Console.WriteLine("Total: " + coffeMachine.TotalCoffee());
        }
    }
}