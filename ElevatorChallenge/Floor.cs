using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge
{
    public class Floor
    {
        public int FloorNumber { get; set; }
        public int WaitingPassengers { get; set; }

        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
            WaitingPassengers = (floorNumber % 2 == 0) ? 3 : 0;
        }
    }
}
