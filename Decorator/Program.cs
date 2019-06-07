using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IService booking = new Room();
            booking = new Wifi(booking);

            booking = new Dinner(new Lunch(booking));

            Console.WriteLine($"Cost {booking.getCost()}");
            Console.WriteLine(booking.getDescription());
        }
    }
}