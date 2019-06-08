namespace ChainOfResponsibility
{
    public class ATM : Account
    {
        public ATM(int balance)
        {
            this._balance = balance;
        }
    }
}