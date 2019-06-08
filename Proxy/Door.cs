using System;

namespace Proxy
{
    public class Door : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Open Door");
        }

        public void Close()
        {
            Console.WriteLine("Close Door");
        }
    }
}