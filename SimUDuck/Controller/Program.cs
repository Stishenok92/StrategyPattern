using System;
using SimUDuck.Model.Function;
using SimUDuck.Model.General;

namespace SimUDuck.Controller
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Mallard Duck");
            Console.WriteLine();
            
            Duck duck = new MallardDuck();
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            duck.Swim();
            Console.WriteLine();

            Console.WriteLine("Change the state");
            Console.WriteLine();
            duck.SetFlyBehavior(new FlyRocketPowered());
            duck.SetQuackBehavior(new MuteQuack());
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            duck.Swim();
        }
    }
}