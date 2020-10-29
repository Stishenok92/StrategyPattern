using System;
using SimUDuck.Model.Function;

namespace SimUDuck.Model.General
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I am Rubber Duck");
        }
    }
}