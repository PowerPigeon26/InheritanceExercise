using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird()
            {
                Age = 2,
                Weight = 78,
                IsBipedal = true,
                Species = "Penguin",
                CanFly = false,
                CanSing = true,
                CanSpeak = false,
                HasFeathers = true
            };
            var reptile1 = new Reptile()
            {
                Age = 12,
                Weight = 2502,
                IsBipedal = false,
                Species = "Red Dragon",
                HasLegs = true,
                HasPoison = false,
                HasScales = true,
                IsColdBlooded = false
            };

            bird1.PrintBirdMembers();
            Console.WriteLine("\n");
            reptile1.PrintReptileMembers();
        }
    }
}
