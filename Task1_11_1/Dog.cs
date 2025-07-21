using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_11_1
{
    internal class Dog : Animal
    {
        public override string Name { get => "Собака";  }

        public override string Say()
        {
            return "Гав!";
        }
    }
}
