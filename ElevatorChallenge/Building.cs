using ElevatorChallenge;
using System.Collections.Generic;
using System.Linq;

public class Building
{
    public List<Elevator> Elevators { get; }
    public List<Floor> Floors { get; }

    public Building(int numberOfFloors, int numberOfElevators, int elevatorWeightLimit)
    {
        Floors = Enumerable.Range(0, numberOfFloors)
                           .Select(floor => new Floor(floor))
                           .ToList();
        Elevators = Enumerable.Range(0, numberOfElevators)
                              .Select(_ => new Elevator(elevatorWeightLimit))
                              .ToList();
    }

    public Elevator GetNearestAvailableElevator(int floorNumber)
    {
        return Elevators.OrderBy(elevator => Math.Abs(elevator.CurrentFloor - floorNumber))
                        .FirstOrDefault();
    }

    public void CallElevator(int floorNumber)
    {
        var elevator = GetNearestAvailableElevator(floorNumber);
        if (elevator != null)
        {
            elevator.MoveToFloor(floorNumber);
            var passengers = Floors[floorNumber].WaitingPassengers;
            if (elevator.CanAddPassengers(passengers))
            {
                elevator.AddPassengers(passengers);
                Floors[floorNumber].WaitingPassengers = 0;
            }
        }
    }

    public string GetElevatorStatus()
    {
        return string.Join("\n", Elevators.Select(e =>
            $"Floor: {e.CurrentFloor}, Moving: {e.IsMoving}, Direction: {e.Direction}, Passengers: {e.PassengerCount}"));
    }
}