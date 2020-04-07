namespace Builder
{
    public class Director
    {
        private IPlaneBuilder _builder;

        public Director(IPlaneBuilder builder)
        {
            _builder = builder;
        }

        public void Constract()
        {
            _builder.MakeSeats(100);
            _builder.MakeEngine(10);
        }
    }
}