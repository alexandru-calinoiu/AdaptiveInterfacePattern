namespace Sample.Builder
{
    public class Factory
    {
        public Car BuildCar()
        {
            var myCar = Car.BeginBuild().WithEngine(new DieselEngine()).Build();

            return myCar;
        }
    }

    public class DieselEngine : EngineBase
    {
    }
}