using System;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class AstronautHead : Head
    {
        public bool HasHelmet { get; set; } = true;
        public bool HasFreckles { get; set; }

        //override allows you to change the behavior of the base class that you're inheriting from
        public override void Greet()
        {
            Console.WriteLine("Major Tom to Ground Control....");
            
            //talking to the class you're inheriting from
            base.Greet();
        }

        public void Observe()
        {
            Console.WriteLine("The Astronaut sees everything all at once.  Across time.");
        }

    }
}
