namespace ChristmasLights
{
    public class Lights
    {
        private bool[,] _lights = new bool[1000, 1000];

        public int LightsOnCounter()
        {
            return 0;
        }

        public void TurnOn(Coordinates start, Coordinates end)
        {
            _lights[start._x, start._y] = true;
            _lights[end._x, end._y] = true;
        }
    }
}