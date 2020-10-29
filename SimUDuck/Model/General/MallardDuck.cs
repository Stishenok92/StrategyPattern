using System;
using SimUDuck.Model.Function;

namespace SimUDuck.Model.General
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I am Mallard Duck!");
        }
    }
}