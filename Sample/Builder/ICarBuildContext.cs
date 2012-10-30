namespace Sample.Builder
{
    public interface ICarBuildContext
    {
        ICarBuildContext WithEngine(EngineBase engine);
        ICarBuildContext WithDriverSeat(SeatBase seat);
        ICarBuildContext WithPassangerSeat(SeatBase seat);
        ICarBuildContext WithWheels(WheelType wheelType);
        ICarBuildContext WithBrakes(BreakBase breakBase);
        Car Build();
    }
}