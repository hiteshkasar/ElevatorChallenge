using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge
{
    public class Elevator
    {
        public int CurrentFloor { get; set; }
        public bool IsMoving { get; set; }
        public string Direction { get; set; }
        public int PassengerCount { get; set; }
        public int WeightLimit { get; set; }

        public Elevator(int weightLimit)
        {
            CurrentFloor = 0;
            IsMoving = false;
            Direction = "None";
            PassengerCount = 0;
            WeightLimit = weightLimit;
        }

        public void MoveToFloor(int floor)
        {
            if (floor == CurrentFloor) return;

            IsMoving = true;
            Direction = floor > CurrentFloor ? "Up" : "Down";
            CurrentFloor = floor;
            Thread.Sleep(3000);
            IsMoving = false;
            Direction = "None";
        }

        public bool CanAddPassengers(int numberOfPassengers)
        {
            return (PassengerCount + numberOfPassengers) <= WeightLimit;
        }

        public void AddPassengers(int numberOfPassengers)
        {
            if (CanAddPassengers(numberOfPassengers))
            {
                PassengerCount += numberOfPassengers;
            }
        }

        public void RemovePassengers(int numberOfPassengers)
        {
            PassengerCount = Math.Max(PassengerCount - numberOfPassengers, 0);
        }
    }
}
