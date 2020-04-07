namespace Builder
{
    public class PlaneBuilder : IPlaneBuilder
    {
        
        private Plane _plane;
        public PlaneBuilder()
        {
            _plane = new Plane();
        }

        public void MakeSeats(int amount)
        {
            _plane.AmountSeats = amount;
        }

        public void MakeEngine(int power)
        {
            _plane.PowerEngine = power;
        }

        public Plane GetPlane()
        {
            return _plane;
        }
    }
}