using DuckLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckLibrary.Classes.Behaviors;

namespace DuckLibrary.Classes
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }
    }
}
