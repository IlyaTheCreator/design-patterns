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

                if (duck is IQuackable)
                {
                    Console.WriteLine((duck as IQuackable).Quack());
                }

                if (duck is IFlyable)
                {
                    Console.WriteLine((duck as IFlyable).Fly());
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
