using System;

namespace Mediator
{
    public class MessageMediator : IMessageMediator
    {
        public void SendMessage(User user, string message)
        {
            Console.WriteLine($"{user.Name} send {message}");
        }
    }
}