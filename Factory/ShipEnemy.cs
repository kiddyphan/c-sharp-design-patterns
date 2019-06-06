using System;
using Factory;

namespace Factory
{
    public class ShipEnemy : Enemy
    {
        public ShipEnemy(string name, int damage, string direction) : base(name, damage, direction)
        {
            
        }
    }
}