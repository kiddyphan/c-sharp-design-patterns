using System.Text;

namespace Decorator
{
    public class Dinner : ServiceDecorator
    {
        const int DINNER_COST = 4;

        public Dinner(IService service) : base(service)
        {
        }

        public override int getCost()
        {
            return this._service.getCost() + DINNER_COST;
        }

        public override string getDescription()
        {
            return string.Concat(this._service.getDescription(), $" with Dinner");
        }
    }
}