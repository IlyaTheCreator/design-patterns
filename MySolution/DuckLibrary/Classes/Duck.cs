using System;

namespace DuckLibrary.Classes
{
    public abstract class Duck
    {
        public string Swim()
        {
            return $"Swim {GetType()}";
        }

        abstract public string Display();
    }
}
