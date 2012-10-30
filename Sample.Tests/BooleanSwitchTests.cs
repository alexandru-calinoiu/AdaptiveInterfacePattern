using FluentAssertions;
using Xunit;

namespace Sample.Tests
{
    public class BooleanSwitchTests
    {
        [Fact]
        public void SwitchOnShouldReturnISwitchOn()
        {
            BooleanSwitch.Create().SwitchOn().Should().NotBeNull();
        }

        [Fact]
        public void SwitchOffShouldNotReturnNull()
        {
            BooleanSwitch.Create().SwitchOn().SwitchOff().Should().NotBeNull();
        }
    }
}