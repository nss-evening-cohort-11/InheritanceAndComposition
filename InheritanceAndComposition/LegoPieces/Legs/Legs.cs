using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    //Cannot be directly instantiated, just an idea of a class that has to be inherited from
    abstract class Legs
    {
        public string Clothing { get; }
        public string Shoes { get; }
        public bool IsShaved { get; }

        protected Legs(string clothing, string shoes, bool isShaved)
        {
            Clothing = clothing;
            Shoes = shoes;
            IsShaved = isShaved;
        }

        public void Walk(int howManySteps)
        {
            Console.WriteLine($"The legs wearing {Clothing} walked {howManySteps} steps in {Shoes}.");
        }

        public void Kick()
        {
            Console.WriteLine("The legs kicked vigorously.");
        }

        //all classes that inherit must create an override for this method
        public abstract void Dance();

    }
}
