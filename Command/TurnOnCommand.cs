using System;

namespace Command
{
    public class TurnOnCommand : ICommand
    {
        private IDevice _device;

        public TurnOnCommand(IDevice device)
        {
            _device = device;
        }
        public void Execute()
        {
            _device.On();   
        }

        public void Undo()
        {
            _device.Off();
        }

        public void Redo()
        {
            Execute();
        }
    }
}