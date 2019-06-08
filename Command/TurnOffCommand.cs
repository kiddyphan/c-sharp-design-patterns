using System;

namespace Command
{
    public class TurnOffCommand : ICommand
    {
        private IDevice _device;

        public TurnOffCommand(IDevice device)
        {
            _device = device;
        }
        public void Execute()
        {
            _device.Off();   
        }

        public void Undo()
        {
            _device.On();
        }

        public void Redo()
        {
            Execute();
        }
    }
}