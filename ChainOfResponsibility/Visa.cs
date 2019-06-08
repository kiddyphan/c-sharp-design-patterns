namespace ChainOfResponsibility
{
    public class Visa : Account
    {
        public Visa(int balance)
        {
            this._balance = balance;
        }
    }
}