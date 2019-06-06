using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var robot = EnemyFactory.makeEnemyRobot("Robot Boss");
            var ship = EnemyFactory.makeEnemyShip("Ship Boss");
            
            robot.DealtDamage();
            robot.Move();
            
            ship.DealtDamage();
            ship.Move();
        }
    }
}