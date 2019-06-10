namespace Mediator
{
    public class User
    {
        public string Name { get; set; }
        private IMessageMediator _mediator;

        public User(IMessageMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendSMS(string message)
        {
            _mediator.SendMessage(this, message);
        }
    }
}