using System;
using SimUDuck.Model.Function;

namespace SimUDuck.Model.General
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyRocketPowered();
            quackBehavior = new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I am Model Duck!");
        }
    }
}