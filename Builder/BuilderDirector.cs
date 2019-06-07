namespace Builder
{
    public class BuilderDirector
    {
        public Car createLamborghini(LamborghiniBuilder builder)
        {
            builder.createCar();
            builder.addModel();
            builder.addNumberOfWheel();
            builder.addMaxSpeed();
            builder.addColor("Yellow");
            return builder.getCar();
        }
        
        public Car createFerrari(FerrariBuilder builder)
        {
            builder.createCar();
            builder.addModel();
            builder.addNumberOfWheel();
            builder.addMaxSpeed();
            builder.addColor("Red");
            return builder.getCar();
        }
    }
}