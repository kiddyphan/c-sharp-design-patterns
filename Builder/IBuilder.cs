namespace Builder
{
    public interface IBuilder
    {
        Car createCar();
        Car getCar();
        
        void addModel();
        void addNumberOfWheel();
        void addMaxSpeed();
        void addColor(string color);
    }
}