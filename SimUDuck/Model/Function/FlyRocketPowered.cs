using System;
using SimUDuck.Model.Interface;

namespace SimUDuck.Model.Function
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket!...");
        }
    }
}