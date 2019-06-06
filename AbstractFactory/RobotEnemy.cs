using System;
using Factory;

namespace Factory
{
    public class RobotEnemy : Enemy
    {
        public RobotEnemy(string name, int damage, string direction) : base(name, damage, direction)
        {
            
        }
    }
}