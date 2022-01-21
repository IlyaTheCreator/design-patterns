using DuckLibrary.Interfaces;
using System;

namespace DuckLibrary.Classes
{
    public class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public string Swim()
        {
            return $"Swim {GetType()}";
        }

        public string Display() {
            return $"Swim ()";
        }

        public string Fly()
        {
            return flyBehavior.Fly();
        }

        public string Quack()
        {
            return quackBehavior.Quack();
        }
    }
}
