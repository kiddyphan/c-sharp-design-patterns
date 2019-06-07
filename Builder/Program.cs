using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var lamborghiniBuilder = new LamborghiniBuilder();
            var lamborghini = new BuilderDirector().createLamborghini(lamborghiniBuilder);
            
            var ferrariBuilder = new FerrariBuilder();
            var ferrari = new BuilderDirector().createFerrari(ferrariBuilder);

            Console.WriteLine(lamborghini.model);
            Console.WriteLine(lamborghini.color);
            
            Console.WriteLine("==================");
            
            Console.WriteLine(ferrari.model);
            Console.WriteLine(ferrari.color);
        }
    }
}