namespace Decorator
{
    public class Lunch : ServiceDecorator
    {
        const int LUNCH_COST = 3;

        public Lunch(IService service) : base(service)
        {
        }

        public override int getCost()
        {
            return this._service.getCost() + LUNCH_COST;
        }

        public override string getDescription()
        {
            return string.Concat(this._service.getDescription(), $" with Lunch");
        }
    }
}