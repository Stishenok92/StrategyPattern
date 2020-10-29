using System;
using SimUDuck.Model.Interface;

namespace SimUDuck.Model.Function
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak - squeak - squeak...");
        }
    }
}