using Xunit;

namespace ChristmasLights
{
    public class LightsShould
    {
        [Fact]
        public void BeOffByDefault()
        {
            Lights lights = new Lights();

            int numberOfLightsOn = lights.LightsOnCounter();
            
            Assert.Equal(0, numberOfLightsOn);
        }

        [Fact]
        public void BeOnWhenTurnedOn()
        {
            Lights lights = new Lights();

            lights.TurnOn(new Coordinates(0, 0), new Coordinates(2, 2));

            int numberOfLightsOn = lights.LightsOnCounter();
            
            Assert.Equal(9, numberOfLightsOn);
        }

       
    }
}