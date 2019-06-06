namespace Factory
{
    public static class EnemyFactory
    {
        public static IEnemy makeEnemy(string name)
        {
            IEnemy enemy;
            switch (name)
            {
                case "robot":
                    enemy = new RobotEnemy("Robot Boss", 200, "right");
                    break;
                case "ship":
                    enemy = new ShipEnemy("Ship Boss", 120, "forward");
                    break;
                default:
                    enemy = new ShipEnemy("Ship Boss", 120, "forward");
                    break;
            }

            return enemy;
        }
    }
}