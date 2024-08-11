This is a C# console application that is trying to solve Elevator challenge.

To run the console app you just need to open the solution in visual studio (I created and tested in Visual Studio 2022).
You can simply run the application then it will give you three options as below:
1. Call Elevator
2. Show Status
3. Exit

You have to choose your option and test the aplication.

I have added delay of 3 seconds in CallElevator() function to indicate Elevator is busy in the direction to the calling floor.

I also added waiting passenger 3 on even floors

You can change total number of floors, number of elevators and elevator weight limit in program.cs file if you have to change default parameters. Current parameters we are passing as:=> var building = new Building(numberOfFloors: 10, numberOfElevators: 3, elevatorWeightLimit: 10);


To run the unit test you have to click on Test menu of visual studio and say Run All Tests and see the result.

Thank you.
