using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_11_1
{
    internal abstract class Animal
    {

        public abstract string Name { get; }

        public abstract string Say();
        
        public void ShowInfo()
        {
            
            Console.WriteLine($"{Name}: {Say()}");
        }

    }
}
