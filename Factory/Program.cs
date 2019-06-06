using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var robot = EnemyFactory.makeEnemy("robot");
            var ship = EnemyFactory.makeEnemy("ship");
            
            robot.DealtDamage();
            robot.Move();
            
            ship.DealtDamage();
            ship.Move();
        }
    }
}