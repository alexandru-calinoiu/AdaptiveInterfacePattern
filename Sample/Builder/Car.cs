namespace Sample.Builder
{
    public class Car : ICarBuildContext
    {
        public EngineBase Engine { get; private set; }

        public SeatBase DriveSeat { get; private set; }

        public SeatBase PassangerSeat { get; private set; }

        public WheelType Wheel { get; private set; }

        public BreakBase Break { get; private set; }

        ICarBuildContext ICarBuildContext.WithEngine(EngineBase engine)
        {
            Engine = engine;
            return this;
        }

        ICarBuildContext ICarBuildContext.WithDriverSeat(SeatBase seat)
        {
            DriveSeat = seat;
            return this;
        }

        ICarBuildContext ICarBuildContext.WithPassangerSeat(SeatBase seat)
        {
            PassangerSeat = seat;
            return this;
        }

        ICarBuildContext ICarBuildContext.WithWheels(WheelType wheelType)
        {
            Wheel = wheelType;
            return this;
        }

        ICarBuildContext ICarBuildContext.WithBrakes(BreakBase breakBase)
        {
            Break = breakBase;
            return this;
        }

        Car ICarBuildContext.Build()
        {
            return this;
        }

        private Car()
        {
        }

        public static ICarBuildContext BeginBuild()
        {
            return new Car();
        }
    }
}