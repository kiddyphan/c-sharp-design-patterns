namespace Mediator
{
    public interface IMessageMediator
    {
        void SendMessage(User user, string message);
    }
}