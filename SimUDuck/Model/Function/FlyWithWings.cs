using System;
using SimUDuck.Model.Interface;

namespace SimUDuck.Model.Function
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying...");
        }
    }
}