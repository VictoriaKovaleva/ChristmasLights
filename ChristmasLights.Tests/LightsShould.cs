using System;
using Xunit;

namespace ChristmasLights
{
    public class LightsShould
    {
        [Fact]
        public void BeOff()
        {
            Lights lights = new Lights();
            
            bool actual = lights.TurnOff();
            
            Assert.True(actual);
        }
    }
}