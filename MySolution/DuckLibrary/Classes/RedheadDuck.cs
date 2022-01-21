using DuckLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckLibrary.Classes.Behaviors;

namespace DuckLibrary.Classes
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new DQuack();
        }
    }
}
