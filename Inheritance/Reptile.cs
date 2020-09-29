namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public int NumberOfLegs { get; set; }
        public bool IsAPredator { get; set; }
        public string MovementType { get; set; }
        public bool CanSwim { get; set; }
        // ToString() method
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Alive: {IsAlive}, \nHas Legs: {HasLegs}" +
                $", Number of Legs: {NumberOfLegs}, Is Predator: {IsAPredator}" +
                $"\nMovement Type: {MovementType}, Can Swim: {CanSwim}";
        }
    }
}
