using System;
using System.Collections.Generic;
using System.Text;
using InheritanceAndComposition.LegoPieces.Heads;

namespace InheritanceAndComposition
{
    class Minifigure
    {
        public string Name { get; private set; }
        public Head Head { get; private set; }

        public Minifigure(string name, Head head)
        {
            Name = name;
            Head = head;
        }

        public void SayHello()
        {
            Console.WriteLine($"{Name} is saying hello:");
            Head.Greet();
        }

    }
}
