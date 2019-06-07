namespace Builder
{
    public abstract class Car
    {
        public abstract string model { get; set; }
        public abstract int numberOfWheel { get; set; }
        public abstract int maxSpeed { get; set; }
        public abstract string color { get; set; }
    }
}