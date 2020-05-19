using System;

namespace lsp
{
    public class ElectricCar : Vehicle
    {
        private const int BATTERY_FULL = 100;

        public int BatteryLevel { get; private set; }

        public override void Refuel()
        {
            
        }

        public override void Charge()
        {
           BatteryLevel = BATTERY_FULL;
        }
    }
}
