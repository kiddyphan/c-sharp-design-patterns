using System;

namespace Facade
{
    public class Computer
    {
        public void QuitAllApplication()
        {
            Console.WriteLine("Computer: Quit all application");
        }
        
        public void ShowShutDownScreen()
        {
            Console.WriteLine("Computer: Show shutdown screen");
        }
        
        public void ShowWelcomeScreen()
        {
            Console.WriteLine("Computer: Show welcome screen");
        }
        
        public void ShowBios()
        {
            Console.WriteLine("Computer: Show Bios");
        }
        
        public void PowerOn()
        {
            Console.WriteLine("Computer: Turn power on");
        }
        
        public void PowerOff()
        {
            Console.WriteLine("Computer: Turn power off");
        }
        
        public void FreeMemory()
        {
            Console.WriteLine("Computer: Free memory");
        }
        
    }
}