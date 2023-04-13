namespace Billiste
{
    public class Dealer
    {
        private string _name;
        private string _adress;
        public List<Car> _cars { get; }

        public Dealer(string name, string adress)
        {
            _name = name;
            _adress = adress;
            _cars = new List<Car>();
        }

        public void AddCarToDealer(Car car)
        {
            _cars.Add(car);
        }

        public void RemoveCarFromDealerWithRegNum(string regNum)
        {
            var carToRemove = _cars.FirstOrDefault(car => car.RegistrationNumber.Equals(regNum));
            if (carToRemove != null) _cars.Remove(carToRemove);
        }

        public List<Car> FetchOldCars(int yearCarIsOlderThan)
        {
            return _cars.Where(car => car.Year < yearCarIsOlderThan).ToList();
        }

        public List<Car> FetchLongDistanceCars(int minimumDistanceDriven)
        {
            return _cars.Where(car => car.DistanceDriven > minimumDistanceDriven).ToList();
        }
    }
}
