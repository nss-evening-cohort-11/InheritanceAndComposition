using System;
using System.Collections.Generic;
using InheritanceAndComposition.LegoPieces.Heads;

namespace InheritanceAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronautHead = new AstronautHead();
            var pirateHead = new PirateHead();
            var cowgirlHead = new CowgirlHead();

            cowgirlHead.Greet();
            cowgirlHead.HairFlip();
            
            pirateHead.Greet();
            pirateHead.Sing();

            astronautHead.Greet();
            astronautHead.Observe();
            
            var heads = new List<Head>();
            heads.Add(astronautHead);
            heads.Add(pirateHead);
            heads.Add(cowgirlHead);

            Console.WriteLine(new string('=',50));
            foreach (var head in heads)
            {
                Console.WriteLine($"The {head.HairColor} haired, {head.EyeColor} eyed head is greeting you...");
                head.Greet();
            }


            var astronaut = new Minifigure("Major Tom", astronautHead);
            var cowgirl = new Minifigure("Jessie",cowgirlHead);

            cowgirl.SayHello();
            astronaut.SayHello();


        }
    }
}
