using System.ComponentModel.Design;

namespace Garage.Library

bool exit = false;
var garage = new Garage;
var parkinSpot = new ParkingSpot;
do
{
    int action;
Console.WriteLine("what do you wat to do?");
    action = Console.ReadLine();
    Console.WriteLine("1) Enter a car entery ");
    action = Console.ReadLine();
    Console.WriteLine("2) Enter a car exit ");
    action = Console.ReadLine();
    Console.WriteLine("3) Generate report");
    action = Console.ReadLine();
    Console.WriteLine("4) Exit ");
    action = Console.ReadLine();

    if (action = 1)
    {
        Console.WriteLine("enter parking spot Number");
        string licencePlate = Console.ReadLine();

        if (garage.IsOccupied(spotNumber))
        {
            Console.WriteLine("Parking spot is occupied");
            
        }
        else
{
    Console.Write("Enter license plate: ");
    string licensePlate = Console.ReadLine()!;
    Console.Write("Enter entry date/time");
    DateTime entryTime = DateTime.Parse(Console.ReadLine()!);

    if (garage.TryOccupy(spotNumber, licensePlate, entryTime))
    {
        Console.WriteLine("Car entry recorded.");
    }
}
    }
        if (action = 2)
        {
            Console.Write("Enter parking spot number: ");
            int spotNumber = int.Parse(Console.ReadLine()!);
            if (!garage.IsOccupied(spotNumber))
            {
                Console.WriteLine("Parking spot is not occupied");
        
            }
            else
            {
        
                Console.Write("Enter exit date/time");
                DateTime exitTime = DateTime.Parse(Console.ReadLine()!);
        
                if (garage.TryExit(spotNumber, exitTime, out decimal costs))
                {
                    Console.WriteLine($"Costs are {costs}€");
                }
            }
        }
        if (action = 3)
        {
            Console.WriteLine(garage.GenerateReport());
        }
        if (action = 4)
        {
             exit = true;
        }
        

}
while (!exit) ;