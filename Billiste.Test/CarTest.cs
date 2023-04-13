namespace Billiste.Test
{
    public class CarTests
    {
      
        [Test]
        public void TestNewCar()
        {
            //arrange
            var car = new Car("Toyota", "AB12345", 2002, 170000);
            //act

            //assert
            Assert.AreEqual("Toyota", car.Brand);
            Assert.AreEqual("AB12345", car.RegistrationNumber);
            Assert.AreEqual(2002, car.Year);
            Assert.AreEqual(170000, car.DistanceDriven);
        }
    }
}