using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() { }

        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasLegs { get; set; }
        public bool HasPoison { get; set; }

        public void PrintReptileMembers()
        {
            PrintAnimalMembers();
            Console.WriteLine($"The {Species}\nHas scales: {HasScales}\n" +
                $"Is cold blooded: {IsColdBlooded}\nHas legs: {HasLegs}\nHas poison: {HasPoison}");
        }
    }
}
