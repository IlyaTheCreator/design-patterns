using DuckPool;
using System;
using System.Collections.Generic;

namespace bruhDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mDuck = new MallardDuck();
            Duck rDuck = new RedheadDuck();

            List<Duck> ducks = new List<Duck>()
            {
                mDuck,
                rDuck
            };

            ducks.ForEach(duck => {
                Console.WriteLine(duck.Quack());
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Display());
            });

            Console.ReadKey();
        }
    }
}
