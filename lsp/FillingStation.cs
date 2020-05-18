namespace lsp
{
    public class FillingStation
    {
        public void refuel(Vehicle vehicle)
        {
            if (typeof(PetrolCar).IsInstanceOfType(vehicle)) {
                vehicle.fillUpWithFuel();
            }
        }

        public void charge(Vehicle vehicle)
        {
            if (typeof(ElectricCar).IsInstanceOfType(vehicle)) {
                vehicle.chargeBattery();
            }
        }
    }
}
