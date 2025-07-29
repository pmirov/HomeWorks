using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_13_3
{
    internal class Player : Character
    {
        int _heathPotionCount = 3;

        public Player(string name, int health = 50, int damage = 5) 
            : base(name, health, damage)
        {
            Name = name;
            
        }

        public override void Attack(Character target)
        {
            Damage = 5;
            base.Attack(target);
        }

        public void UseHealthPotion()
        {
           
            if (_heathPotionCount > 0)
            {
                Health += 10;
                _heathPotionCount--;
                Console.WriteLine($"Применено зелье! Осталось {_heathPotionCount} зелья");
            }
            else
            {
                Console.WriteLine("Зелье закончилось!");
            }
           

        }
    }
}
