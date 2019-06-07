namespace Decorator
{
    public class Wifi : ServiceDecorator
    {
        const int WIFI_COST = 2;

        public Wifi(IService service) : base(service)
        {
        }

        public override int getCost()
        {
            return this._service.getCost() + WIFI_COST;
        }

        public override string getDescription()
        {
            return string.Concat(this._service.getDescription(), $" with Wifi");
        }
    }
}