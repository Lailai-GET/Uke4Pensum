namespace Billiste
{
    public class Car
    {
        public string Brand { get; }
        public string RegistrationNumber { get; }
        public int Year { get; }
        public int DistanceDriven { get; }

        public Car(string brand, string registrationNumber, int year, int distanceDriven)
        {
            Brand = brand;
            RegistrationNumber = registrationNumber;
            Year = year;
            DistanceDriven = distanceDriven;
        }
    }
}
