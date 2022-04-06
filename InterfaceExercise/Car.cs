using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany 
    {
        public bool HasTrunk { get; set; }
        public bool HasLeatherSeats { get; set; }
        public bool HasSteering { get; set; }
        public int HowManyWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof {get; set; }
        public string Name { get; set; }
        public string CorpName { get; set; }
        public string Motto { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
    }
}
