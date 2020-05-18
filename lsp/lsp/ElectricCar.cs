using System;

namespace lsp
{
    public class ElectricCar : Vehicle
    {
        private const int BATTERY_FULL = 100;

        public int BatteryLevel { get; private set; }

        public override void fillUpWithFuel()
        {
            throw new InvalidOperationException("It's an electric car");
        }

        public override void chargeBattery()
        {
            BatteryLevel = BATTERY_FULL;
        }

    }
}
