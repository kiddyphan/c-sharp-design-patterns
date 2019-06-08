using System;

namespace Proxy
{
    public class SecureDoorProxy
    {
        private IDoor _door;

        public SecureDoorProxy(IDoor door)
        {
            this._door = door;
        }

        private bool Authenticate(string password)
        {
            if (password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OpenWithPassword(string password)
        {
            if (this.Authenticate(password))
            {
                this._door.Open();
            }
            else
            {
                Console.WriteLine("You cannot open this door!");
            }

        }

        public void Close()
        {
            this._door.Close();
        }
    }
}