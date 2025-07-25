using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_13_3
{
    internal class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

      
        public bool isAlive
        {
            get
            {
                return Health > 0;
            }

        }

        public Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public virtual void Attack(Character target)
        {
            target.Health -= Damage;
            Console.WriteLine($"{Name} наносит {Damage} урона {target.Name}");
        }

    }
}
