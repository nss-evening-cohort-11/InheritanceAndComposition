using System;
using System.Collections.Generic;
using System.Text;
using InheritanceAndComposition.LegoPieces.Heads;
using InheritanceAndComposition.LegoPieces.Legs;
using InheritanceAndComposition.LegoPieces.Torsos;

namespace InheritanceAndComposition
{
    class Minifigure
    {
        public string Name { get; }
        public Head Head { get; }
        public Torso Torso { get; }
        public Legs Legs { get; }
        
        public Minifigure(string name, Head head, Torso torso, Legs legs)
        {
            Name = name;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void SayHello()
        {
            Console.WriteLine($"{Name} is saying hello:");
            Torso.Wave();
            Legs.Walk(20);
            Head.Greet();
        }

    }
}
