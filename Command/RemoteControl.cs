namespace Command
{
    public class RemoteControl
    {
        public void Press(ICommand command, int number)
        {
            switch (number)
            {
                // Execute
                case 1:
                    command.Execute();
                    break;
                // Undo
                case 2:
                    command.Undo();
                    break;
                // Redo
                case 3:
                    command.Redo();
                    break;

                default:
                    command.Execute();
                    break;
            }
        }
    }
}