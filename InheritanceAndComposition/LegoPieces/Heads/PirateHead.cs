using Console = System.Console;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class PirateHead : Head 
    {
        public bool HasPatch { get; set; }
        public string FacialHair { get; set; }

        public void Sing()
        {
            Console.WriteLine($"The {HairColor} pirate sang 'Yo ho ho and a bottle of rum' out of tune.");
        }

        public void Laugh()
        {
            Console.WriteLine("Har Har Har.");
        }

        public override void Greet()
        {
            Console.WriteLine("AAAAAAARRRRRRGGGGGGGGGGGGGHHH");
        }
    }
}
