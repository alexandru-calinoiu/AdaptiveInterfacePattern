namespace Sample
{
    public enum States
    {
        On,
        Off
    }

    public class BooleanSwitch : IOnSwitch, IOffSwitch
    {
        private States _state;

        protected BooleanSwitch()
        {
            _state = States.Off;
        }

        public IOffSwitch SwitchOff()
        {
            _state = States.Off;

            return this;
        }

        public IOnSwitch SwitchOn()
        {
            _state = States.On;

            return this;
        }

        public static IOffSwitch Create()
        {
            return new BooleanSwitch();
        }
    }
}