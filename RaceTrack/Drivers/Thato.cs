using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Thato : Driver
    {
        public Thato(RaceCar car) : base(car)
        {
            Name = "Thato";
            SkillLevel = 2;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}