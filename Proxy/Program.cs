using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var door = new Door();
            var secureDoor = new SecureDoorProxy(door);
            secureDoor.OpenWithPassword("456");
            
            secureDoor.OpenWithPassword("123");
            secureDoor.Close();
        }
    }
}