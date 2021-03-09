using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RaceTrack.RaceTrack.Cars
{
    public  class Ferrari : RaceCar
    {
        public Ferrari()
        {
            Name = "Ferrari Enzo";
            TopSpeed = 350;

        }

         public override void StartEngine()
        {
            Console.WriteLine($"The {Name} prances to life!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} takes a breather!");
            base.Brake();
        }

        public override void StopEngine()
        {
            
            Console.WriteLine($"The {Name} comes to a stop.");
        }
    }
}