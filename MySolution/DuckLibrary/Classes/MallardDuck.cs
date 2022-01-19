using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckLibrary.Interfaces;

namespace DuckLibrary.Classes
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return $"Display {GetType()}";
        }

        public string Fly()
        {
            return $"Fly {GetType()}";
        }

        public string Quack()
        {
            return $"Quack {GetType()}";
        }
    }
}
