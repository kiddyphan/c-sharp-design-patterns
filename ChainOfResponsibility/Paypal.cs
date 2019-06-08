namespace ChainOfResponsibility
{
    public class Paypal : Account
    {
        public Paypal(int balance)
        {
            this._balance = balance;
        }
    }
}