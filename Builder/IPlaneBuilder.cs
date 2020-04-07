namespace Builder
{
    public interface IPlaneBuilder
    {
        void MakeSeats(int amount);
        void MakeEngine(int power);
        Plane GetPlane();
    }
}