namespace Garage.Library
{
    public class Garage
    {

        public ParkingSpot[] parkingSpots { get; } = new ParkingSpot[50];
        //public int ParkingSpotNumber { get; set; }
        DateTime Enterytime { get; set; }
        bool IsOccupied(int parkingSpotNumber)
        {
            if (parkingSpots[parkingSpotNumber] == null) { return false; }
            else { return true; }
        }
        bool TryOcupie(int parkingSpotNumber, string licensePlate, DateTime entryTime)
        {
            if (!(IsOccupied(parkingSpotNumber)))
            {
                new ParkingSpot(licensePlate, entryTime)
                return true;
            }
            else { return false; }
        }
        bool TryExit(int parkingSpotNumber, DateTime exitTime, out double costs)
        {

            if (parkingSpots[parkingSpotNumber] != null)
            {

                TimeSpan parkingTime = (exitTime - Enterytime);
                double actualParkingTime = parkingTime.TotalMinutes;
                if (actualParkingTime <= 15)
                {
                    costs = 0;
                }
                else
                {
                    costs = 3 * (Math.Ceiling(actualParkingTime / 30));
                }
                return true;
            }
            else
            {
                costs = 0;
                return false;
            }

        }
        string[] GenerateReport()
        {
            string[] report = new string[52];
            report[0] = "| Spot | Licence Plate |";
            report[1] = "| ---- | ------------- |";
            for (int i = 2; i < report.Length; i++) 
            {
                report[i]="|"+i+"|"+""parkingSpots.LicensePlate;
            }


        }
    }

}