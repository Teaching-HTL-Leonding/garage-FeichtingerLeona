namespace Garage.Library
{
    public class ParkingSpot
    {
        public ParkingSpot(string licancePlate, DateTime enterytime ) 
        {
            LicensePlate = licancePlate;
            EnteryTime = enterytime;
        }
        public string LicensePlate { get; set; }
        public DateTime EnteryTime { get; set; } = DateTime.Now;
    }
}
