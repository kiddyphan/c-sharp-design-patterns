using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var jolly = new Sheep("Jolly", "Mountain Sheep");
            var dolly = jolly.Clone();

            Console.WriteLine(dolly.Type);
            Console.WriteLine("==========");

            dolly.Name = "Dolly";
            dolly.Type = "Clone Sheep";
            
            Console.WriteLine(dolly.Name);
            Console.WriteLine(dolly.Type);
        }
    }
}