using System;

namespace Builder
{
    class BulderTesting
    {
        static void Main(string[] args)
        {
            IPlaneBuilder builder = new PlaneBuilder();
            Director director = new Director(builder);
            director.Constract();

            Plane plane = builder.GetPlane();
            plane.PrintInfo();
        }
    }
}
