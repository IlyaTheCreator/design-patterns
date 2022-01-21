using DuckLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckLibrary.Classes.Behaviors;

namespace DuckLibrary.Classes
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
    }
}
