using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _1_13_3
{
    internal class Monster : Character
    {
        Random random = new Random();
        public Monster(string name = "Злобный гоблин", int health = 20, int damage = 0) :
            base(name, health, damage)
        {
          

        }
        public override void Attack(Character target)
        {
            Damage = random.Next(1, 6);
            base.Attack(target);
        }
    }
}
