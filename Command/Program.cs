using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();
            var turnOnCommand = new TurnOnCommand(tv);
            var turnOffCommand = new TurnOffCommand(tv);

            var remoteControl = new RemoteControl();
            remoteControl.Press(turnOnCommand, 1);
            
            remoteControl.Press(turnOffCommand, 1);
            remoteControl.Press(turnOffCommand, 2);
        }
    }
}