// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using RobotMovement;
using RobotMovement.Models;

Processor processor = new Processor(new Position());

Console.WriteLine("Enter Command:");
var commandPlace = Console.ReadLine();

int[] commandCoordinates = new int[2];
Console.WriteLine("Enter Coordinates:");

Console.WriteLine("Enter X :");
commandCoordinates[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y :");
commandCoordinates[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Facing:");
var commandFacing = Console.ReadLine();

if(commandPlace == "PLACE")
   processor.Place(commandCoordinates[0], commandCoordinates[1], commandFacing!);

Console.WriteLine("Enter Next Command");
var newCommand = Console.ReadLine();

switch (newCommand)
{
    case "MOVE":
        processor.Move();break;
    case "LEFT":
        processor.Left();break;
    case "RIGHT":
        processor.Right();break;
    default :
        Console.WriteLine("Only commands accepted are MOVE,LEFT,RIGHT");break;
}

Console.WriteLine(" REPORT : ");
processor.Report();



