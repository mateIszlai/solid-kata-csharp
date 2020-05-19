namespace lsp
{
    public class FillingStation
    {
        public void refuel(Vehicle vehicle)
        {
            vehicle.Refuel();
        }

        public void charge(Vehicle vehicle)
        {
            vehicle.Charge();
        }
    }
}
