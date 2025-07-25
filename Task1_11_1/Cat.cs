using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_11_1
{
    internal class Cat : Animal
    {
        public override string Name { get => "Кошка"; }

        public override string Say()
        {
            return "Мяу!";
        }
    }
}
