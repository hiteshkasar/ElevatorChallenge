using System;

public class Program
{
    public static void Main()
    {
        var building = new Building(numberOfFloors: 10, numberOfElevators: 3, elevatorWeightLimit: 10);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Elevator System");
            Console.WriteLine("1. Call Elevator");
            Console.WriteLine("2. Show Status");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter floor number to call elevator: ");
                    if (int.TryParse(Console.ReadLine(), out var floorNumber))
                    {
                        building.CallElevator(floorNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid floor number.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Elevator Status:");
                    Console.WriteLine(building.GetElevatorStatus());
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}