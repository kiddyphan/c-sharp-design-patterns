using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageMediator = new MessageMediator();
            var user1 = new User(messageMediator) {Name = "John"};
            var user2 = new User(messageMediator) {Name = "Jane"};
            
            user1.SendSMS("Hello!");
            user2.SendSMS("Listen!");
        }
    }
}