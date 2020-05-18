using System;

namespace lsp
{
    public class PetrolCar : Vehicle
    {
        private const int FUEL_TANK_FULL = 100;
        public int FuelTankLevel { get; private set; }


        public override void fillUpWithFuel()
        {
            FuelTankLevel = FUEL_TANK_FULL;
        }

        public override void chargeBattery()
        {
            throw new InvalidOperationException("A petrol car cannot be recharged");
        }
    }
}
