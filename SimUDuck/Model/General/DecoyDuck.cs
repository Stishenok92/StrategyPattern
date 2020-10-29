using System;
using SimUDuck.Model.Function;

namespace SimUDuck.Model.General
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I am Decoy Duck!");
        }
    }
}