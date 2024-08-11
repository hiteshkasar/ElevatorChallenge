using ElevatorChallenge;

namespace ElevatorNunitTests
{
    public class ElevatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Elevator_ShouldMoveToCorrectFloor()
        {
            var elevator = new Elevator(weightLimit: 10);
            elevator.MoveToFloor(5);
            Assert.AreEqual(5, elevator.CurrentFloor);
        }

        [Test]
        public void Elevator_ShouldAddPassengers()
        {
            var elevator = new Elevator(weightLimit: 10);
            elevator.AddPassengers(5);
            Assert.AreEqual(5, elevator.PassengerCount);
        }

        [Test]
        public void Elevator_ShouldNotExceedWeightLimit()
        {
            var elevator = new Elevator(weightLimit: 10);
            elevator.AddPassengers(15);
            Assert.AreEqual(0, elevator.PassengerCount);  // Assumes passengers are not added if over weight limit
        }

        [Test]
        public void Elevator_ShouldRemovePassengers()
        {
            var elevator = new Elevator(weightLimit: 10);
            elevator.AddPassengers(5);
            elevator.RemovePassengers(2);
            Assert.AreEqual(3, elevator.PassengerCount);
        }
    }

    //[TestFixture]
    public class BuildingTests
    {
        [Test]
        public void Building_ShouldReturnNearestElevator()
        {
            var building = new Building(numberOfFloors: 10, numberOfElevators: 2, elevatorWeightLimit: 10);
            building.Elevators[0].MoveToFloor(2);
            building.Elevators[1].MoveToFloor(5);

            var nearestElevator = building.GetNearestAvailableElevator(3);
            Assert.AreEqual(0, building.Elevators.IndexOf(nearestElevator));  // Elevator 0 is nearest
        }
    }
}