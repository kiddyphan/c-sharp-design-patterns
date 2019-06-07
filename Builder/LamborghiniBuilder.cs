namespace Builder
{
    public class LamborghiniBuilder : IBuilder
    {
        private Lamborghini _car;

        public Car createCar()
        {
            this._car = new Lamborghini();
            return this._car;
        }

        public void addModel()
        {
            this._car.model = "Lamborghini";
        }

        public void addNumberOfWheel()
        {
            this._car.numberOfWheel = 4;
        }

        public void addMaxSpeed()
        {
            this._car.maxSpeed = 300;
        }

        public void addColor(string color)
        {
            this._car.color = color;
        }

        public Car getCar()
        {
            return this._car;
        }
    }
}