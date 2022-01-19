using DuckLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLibrary.Classes
{
    public class RubberDuck : Duck, IQuackable
    {
        public override string Display()
        {
            return $"Display {GetType()}";
        }

        public string Quack()
        {
            return $"Quack {GetType()}";
        }
    }
}
