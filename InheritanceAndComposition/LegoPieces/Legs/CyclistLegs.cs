using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    class CyclistLegs : Legs
    {
        public CyclistLegs() : base("Biker Shorts", "Cyclist Shoes", true)
        {

        }

        public override void Dance()
        {
            Console.WriteLine("Too busy biking to dance.");
        }
    }
}
