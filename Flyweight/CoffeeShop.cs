using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class CoffeeShop
    {
        private readonly CoffeeMachine _coffeeMachine;
        private Dictionary<int, Coffee> _tables = new Dictionary<int, Coffee>();

        public CoffeeShop(CoffeeMachine coffeeMachine)
        {
            this._coffeeMachine = coffeeMachine;
        }

        public void Order(int number, string type)
        {
            _tables.Add(number, _coffeeMachine.MakeCoffee(type));
        }

        public void Serve()
        {
            foreach (var table in _tables.Keys)
            {
                Console.WriteLine($"Serve table: {table}");
            }
        }
    }
}