using System;

namespace Command
{
    public class TV : IDevice
    {
        public void On()
        {
            Console.WriteLine("TV Turn On");
        }

        public void Off()
        {
            Console.WriteLine("TV Turn Off");
        }
    }
}