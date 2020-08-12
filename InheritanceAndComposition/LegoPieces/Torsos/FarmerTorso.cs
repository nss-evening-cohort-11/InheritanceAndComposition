using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    class FarmerTorso : Torso
    {
        public FarmerTorso(Sex sex)
        {
            Clothing = "Red plaid shirt";
            Accessory = "Garden Hoe";
            ArmType = ArmType.Strong;
            Sex = sex;
        }

        public void Garden()
        {
            if (IsStrong())
            {
                Console.WriteLine("Doing the gardening is fun.");
            }
            else
            {
                Console.WriteLine("I hate gardening...");
            }
        }

        protected override bool IsStrong()
        {
            return Sex == Sex.Female;
        }
    }
}
