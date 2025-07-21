using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_11_2
{
    internal class Bird : IFlyable
    {
        public int MaxAttitude { get; }

        public Bird(int maxAttitude)
        {
            MaxAttitude = maxAttitude;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAttitude} метров");
        }
    }
}
