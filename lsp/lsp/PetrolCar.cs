using System;

namespace lsp
{
    public class PetrolCar : Vehicle
    {
        private const int FUEL_TANK_FULL = 100;
        public int FuelTankLevel { get; private set; }

        public override void Charge()
        {
            
        }

        public override void Refuel()
        {
           FuelTankLevel = FUEL_TANK_FULL;
        }
    }
}
