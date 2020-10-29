using System;
using SimUDuck.Model.Interface;

namespace SimUDuck.Model.Function
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly...");
        }
    }
}