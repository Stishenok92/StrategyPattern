using System;
using SimUDuck.Model.Interface;

namespace SimUDuck.Model.General
{
    public abstract class Duck
    { 
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
        
        public void Swim()
        {
            Console.WriteLine("I am swimming...");
        }
        
        public abstract void Display();
    }
}