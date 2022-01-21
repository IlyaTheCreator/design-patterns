using DuckLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLibrary.Classes.Behaviors
{
    public class Squeak : QuackBehavior
    {
        public string Quack()
        {
            return "Пи пи пи";
        }
    }
}
