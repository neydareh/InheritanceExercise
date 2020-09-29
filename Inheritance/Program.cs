using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            #region Bird
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird = new Bird
            {
                Age = 2,
                Name = "Birdy",
                IsAlive = true,
                HasLegs = true,
                CanFly = true,
                HasFeathers = true,
                IsAPredator = false,
                Weight = 15
            };
            #endregion

            #region Reptile
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             * Creatively display the class member values 
             */
            Reptile reptile = new Reptile
            {
                Age = 7,
                Name = "Crockie",
                IsAlive = true,
                HasLegs = true,
                NumberOfLegs = 4,
                IsAPredator = true,
                CanSwim = true,
                MovementType = "Sporadic"
            };
            #endregion
            Console.WriteLine("****Output****");
            Console.WriteLine(bird.ToString());
            Console.WriteLine("");
            Console.WriteLine(reptile.ToString());
            Console.ReadLine();
        }
    }
}
