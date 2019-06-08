using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class CoffeeMachine
    {
        private Dictionary<string, Coffee> _coffees = new Dictionary<string, Coffee>();
        
        public Coffee MakeCoffee(string type)
        {
            if (!_coffees.ContainsKey(type))
            {
                _coffees.Add(type, new Coffee());
            }
            
            return _coffees[type];
        }

        public int TotalCoffee()
        {
            return _coffees.Count;
        }
    }
}