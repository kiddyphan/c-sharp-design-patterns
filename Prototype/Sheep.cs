namespace Prototype
{
    public class Sheep
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Sheep(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public Sheep Clone()
        {
            // MemberwiseClone: Creates a shallow copy of the current Object.
            return this.MemberwiseClone() as Sheep;
        }
    }
}