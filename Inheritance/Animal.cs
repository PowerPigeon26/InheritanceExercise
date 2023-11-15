using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() { }

        public int Age { get; set; }
        public int Weight { get; set; }
        public string Species { get; set; }
        public bool IsBipedal { get; set; }

        public void PrintAnimalMembers()
        {
            Console.WriteLine($"This {Species} is {Age} years old and weighs a whopping {Weight} pounds!");
            Console.WriteLine($"This species is Bipedal: {IsBipedal}");
        }
    }
}
