using System;

namespace DuckPool
{
    public abstract class Duck
    {
        public string Quack()
        {
            return $"Quack {GetType()}";
        }

        public string Swim()
        {
            return $"Swim {GetType()}";
        }

        abstract public string Display();
    }
}
