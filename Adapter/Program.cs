using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoPinPlug = new TwoPinPlug();
            twoPinPlug.GetPower();
            
            var threePinPlug = new ThreePinPlug();
            var twoPinPlugAdapter = new TwoPinPlugAdapter(threePinPlug);
            
            twoPinPlugAdapter.GetPower();
        }
    }
}