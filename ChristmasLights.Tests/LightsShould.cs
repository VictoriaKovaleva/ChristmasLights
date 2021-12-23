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

            int numberOfLightsOn = lights.LightsOnCounter();
            
            Assert.Equal(0, numberOfLightsOn);
        }

       
    }
}