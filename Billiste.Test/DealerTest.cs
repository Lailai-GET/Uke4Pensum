using NUnit.Framework.Constraints;

namespace Billiste.Test
{
    internal class DealerTest
    {
        [Test]
        public void TestEmptyLongCar()
        {
            var dealer = new Dealer("BillibilAS", "Billigkroken 12");

            var shouldBeEmpty = dealer.FetchLongDistanceCars(200000);

            Assert.IsEmpty(shouldBeEmpty);

        }
        [Test]
        public void TestEmptyOldCar()
        {
            var dealer = new Dealer("BillibilAS", "Billigkroken 12");

            var shouldBeEmpty = dealer.FetchOldCars(2000);

            Assert.IsEmpty(shouldBeEmpty);

        }
        [Test]
        public void RemoveCar()
        {
            var dealer = new Dealer("BillibilAS", "Billigkroken 12");
            var car1 = new Car("Toyota", "AB12345", 2002, 170000);
            var car2 = new Car("Opel", "CD67890", 1997, 220000);
            dealer.AddCarToDealer(car1);
            dealer.AddCarToDealer(car2);
            
            dealer.RemoveCarFromDealerWithRegNum("CD67890");

            Assert.AreEqual(1, dealer._cars.Count);
            
        }
        [Test]
        public void FindingLongCar()
        {
            var dealer = new Dealer("BillibilAS", "Billigkroken 12");
            var car1 = new Car("Toyota", "AB12345", 2002, 170000);
            var car2 = new Car("Opel", "CD67890", 1997, 220000);
            dealer.AddCarToDealer(car1);
            dealer.AddCarToDealer(car2);
            var longCars = dealer.FetchLongDistanceCars(200000);

            Assert.AreEqual("Opel", longCars[0].Brand);
            Assert.AreEqual(1, longCars.Count);
            
        }
        [Test]
        public void FindingOldCar()
        {
            var dealer = new Dealer("BillibilAS", "Billigkroken 12");
            var car1 = new Car("Toyota", "AB12345", 2002, 170000);
            var car2 = new Car("Opel", "CD67890", 1997, 220000);
            dealer.AddCarToDealer(car1);
            dealer.AddCarToDealer(car2);
            var oldCars = dealer.FetchOldCars(2000);

            Assert.AreEqual("Opel", oldCars[0].Brand);
            Assert.AreEqual(1, oldCars.Count);

        }
        [Test]
        public void TestAddingCarToDealer()
        {
            var dealer = new Dealer("BillibilAS", "Billigkroken 12");
            var car = new Car("Toyota", "AB12345", 2002, 170000);

            dealer.AddCarToDealer(car);

            Assert.AreEqual("Toyota", dealer._cars[0].Brand);
            Assert.AreEqual(1, dealer._cars.Count);
        }
    }
}
