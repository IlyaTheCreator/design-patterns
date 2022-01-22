using DuckLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLibrary.Classes.Behaviors
{
    public class DQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "Кря кря кря";
        }
    }
}
