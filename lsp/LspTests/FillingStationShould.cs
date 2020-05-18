using lsp;
using NUnit.Framework;

namespace LspTests
{
    [TestFixture]
    public class FillingStationShould
    {
        private const int FULL = 100;
        private FillingStation _fillingStation;

        [SetUp]
        public void SetUp()
        {
            _fillingStation = new FillingStation();
        }

        [TearDown]
        public void TearDown()
        {
            _fillingStation = null;
        }

        [Test]
        public void refuel_a_petrol_car()
        {
            PetrolCar car = new PetrolCar();

            _fillingStation.refuel(car);

            Assert.AreEqual(FULL, car.FuelTankLevel);
        }


        [Test]
        public void not_fail_refueling_an_electric_car()
        {
            ElectricCar car = new ElectricCar();
            Assert.DoesNotThrow(() => _fillingStation.refuel(car));
        }


        [Test]
        public void recharge_an_electric_car()
        {
            ElectricCar car = new ElectricCar();

            _fillingStation.charge(car);

            Assert.AreEqual(FULL, car.BatteryLevel);
        }


        [Test]
        public void not_fail_recharging_a_petrol_car()
        {
            PetrolCar car = new PetrolCar();

            Assert.DoesNotThrow(() => _fillingStation.charge(car));
        }
    }
}
