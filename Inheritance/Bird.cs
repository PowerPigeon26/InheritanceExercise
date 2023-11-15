using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() { }

        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public bool CanSing { get; set; }
        public bool CanSpeak { get; set; }

        public void PrintBirdMembers()
        {
            PrintAnimalMembers();   
            Console.WriteLine($"The {Species}\nCan fly: {CanFly}\n" +
                $"Has feathers: {HasFeathers}\nCan sing: {CanSing}\nCan speak: {CanSpeak}");
        }
    }
}
