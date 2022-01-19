using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLibrary.Classes
{
    public class DecoyDuck : Duck
    {
        public override string Display()
        {
            return $"Display {GetType()}";
        }
    }
}
