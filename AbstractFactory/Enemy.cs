using System;

namespace Factory
{
    public abstract class Enemy: IEnemy
    {
        private string _name { get; set; }
        private int _damage { get; set; }
        private string _direction { get; set; }
        
        public Enemy(string name, int damage, string direction)
        {
            this._name = name;
            this._damage = damage;
            this._direction = direction;
        }
        
        public void DealtDamage()
        {
            Console.WriteLine($"{this._name} deals {this._damage} damages!");
        }
        
        public void Move()
        {
            Console.WriteLine($"{this._name} moves {this._direction}!");
        }
    }
}