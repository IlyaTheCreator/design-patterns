using DuckLibrary.Interfaces;
using System;

namespace DuckLibrary.Classes
{
    public class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string Swim()
        {
            return "Буль буль буль";
        }

        public string Display() {
            return $"{GetType()} | {flyBehavior.GetType()} | {quackBehavior.GetType()}";
        }

        public string Fly()
        {
            return flyBehavior.Fly();
        }

        public string Quack()
        {
            return quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
