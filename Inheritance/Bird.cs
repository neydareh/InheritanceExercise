namespace Inheritance
{
    public class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public bool IsAPredator { get; set; }
        public int Weight { get; set; }

        // ToString() method
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Alive: {IsAlive}, \nHas Legs: {HasLegs}" +
                $", Can Fly: {CanFly}, Has Feather: {HasFeathers}, \nIs Predator: {IsAPredator}" +
                $", Weight: {Weight}lbs";
        }
    }
}
