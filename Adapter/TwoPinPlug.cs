using System;

namespace Adapter
{
    public class TwoPinPlug: ITwoPinPlug
    {
        public void GetPower()
        {
            Console.WriteLine("Get Power via 2 pin");
        }
    }
}