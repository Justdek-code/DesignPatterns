using System;

namespace Builder
{
    public class Plane
    {
        public int AmountSeats;
        public int PowerEngine;
        
        public void PrintInfo()
        {
            Console.WriteLine($"Seats: {AmountSeats} \nPower of Engine: {PowerEngine}");
        }
    }
}