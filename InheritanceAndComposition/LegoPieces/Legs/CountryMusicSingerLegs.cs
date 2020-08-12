using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    class CountryMusicSingerLegs : Legs
    {
        public CountryMusicSingerLegs(string clothing, bool isShaved) : base(clothing, "Boots", isShaved)
        {
        }

        public override void Dance()
        {
            Console.WriteLine("Country music singer legs do a square dance.");
        }
    }
}
