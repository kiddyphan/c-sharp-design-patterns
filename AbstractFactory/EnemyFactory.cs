namespace Factory
{
    public static class EnemyFactory
    {
        public static IEnemy makeEnemyRobot(string name)
        {
            return new RobotEnemy(name, 200, "right");
        }

        public static IEnemy makeEnemyShip(string name)
        {
            return new ShipEnemy(name, 120, "forward");
        }
    }
}