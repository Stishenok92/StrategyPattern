using System;
using SimUDuck.Model.Interface;

namespace SimUDuck.Model.Function
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I am cannot quack...");
        }
    }
}