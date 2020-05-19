using lsp;
using NUnit.Framework;

namespace LspTests
{
    [TestFixture]
    public class VehicleShould
    {
        [Test]
        public void start_engine()
        {
            Vehicle vehicle = new TestableVehicle();
            vehicle.startEngine();

            Assert.IsTrue(vehicle.engineIsStarted());
        }

        [Test]
        public void stop_engine()
        {
            Vehicle vehicle = new TestableVehicle();

            vehicle.startEngine();
            vehicle.stopEngine();

            Assert.IsFalse(vehicle.engineIsStarted());
        }


        public class TestableVehicle : Vehicle
        {

            public override void Refuel()
            {
            
            }

            public override void Charge()
            {
   
            }
        }
    }
}
