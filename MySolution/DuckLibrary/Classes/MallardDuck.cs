using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckLibrary.Classes.Behaviors;

namespace DuckLibrary.Classes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new DQuack();
        }
    }
}
