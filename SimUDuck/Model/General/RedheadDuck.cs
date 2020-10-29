using System;
using SimUDuck.Model.Function;

namespace SimUDuck.Model.General
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior =new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I am Redhead Duck");
        }
    }
}