using System;
using System.Collections.Generic;
using DuckLibrary.Classes;
using DuckLibrary.Interfaces;

namespace MySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck rubberDuck = new RubberDuck();
            Duck decoyDuck = new DecoyDuck();

            List<Duck> ducks = new List<Duck>()
            {
                mallardDuck,
                redheadDuck,
                rubberDuck,
                decoyDuck
            };

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Quack());
                Console.WriteLine(duck.Fly());

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
