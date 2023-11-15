using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            //COMPLETED

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            //COMPLETED
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            //COMPLETED



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

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
