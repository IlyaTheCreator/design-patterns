using System;
using System.Collections.Generic;
using DuckLibrary.Classes;
using DuckLibrary.Classes.Behaviors;
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

            IFlyBehavior flyNoWay = new FlyNoWay();
            IQuackBehavior muteQuack = new MuteQuack();

            redheadDuck.SetFlyBehavior(flyNoWay);
            redheadDuck.SetQuackBehavior(muteQuack);

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
