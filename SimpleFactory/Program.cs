using System;

namespace Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = CarFactory.createCar();
            car.Drive();
        }
    }
}