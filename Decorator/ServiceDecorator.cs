namespace Decorator
{
    public abstract class ServiceDecorator : IService
    {
        protected IService _service;

        public ServiceDecorator(IService service)
        {
            this._service = service;
        }

        public virtual int getCost()
        {
            return this._service.getCost();
        }

        public virtual string getDescription()
        {
            return this._service.getDescription();
        }
    }
}