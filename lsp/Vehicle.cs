namespace lsp
{
    public abstract class Vehicle
    {
        private bool engineStarted = false;

        public void startEngine()
        {
            this.engineStarted = true;
        }

        public bool engineIsStarted()
        {
            return engineStarted;
        }

        public void stopEngine()
        {
            this.engineStarted = false;
        }

        public abstract void fillUpWithFuel();

        public abstract void chargeBattery();
    }
}
