using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new ComputerFacade(new Computer());
            
            computer.TurnOn();
            Console.WriteLine("==========");
            computer.TurnOff();
            
        }
    }
}