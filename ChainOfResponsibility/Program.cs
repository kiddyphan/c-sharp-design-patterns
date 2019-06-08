using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var atm = new ATM(100);
            var visa = new Visa(200);
            var paypal = new Paypal(500);
            
            atm.setBackupAccount(visa);
            visa.setBackupAccount(paypal);
            
            atm.Pay(250);
        }
    }
}