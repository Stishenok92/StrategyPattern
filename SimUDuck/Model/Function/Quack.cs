using System;
using SimUDuck.Model.Interface;

namespace SimUDuck.Model.Function
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack - quack - quack...");
        }
    }
}