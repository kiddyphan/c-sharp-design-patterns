namespace Facade
{
    public class ComputerFacade
    {
        private readonly Computer _computer;

        public ComputerFacade(Computer computer)
        {
            this._computer = computer;
        }

        public void TurnOn()
        {
            this._computer.PowerOn();
            this._computer.ShowBios();
            this._computer.ShowWelcomeScreen();
        }

        public void TurnOff()
        {
            this._computer.QuitAllApplication();
            this._computer.ShowShutDownScreen();
            this._computer.FreeMemory();
            this._computer.PowerOff();
        }
    }
}