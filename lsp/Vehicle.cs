namespace lsp
{
    public abstract class Vehicle
    {
        private bool _engineStarted = false;

        public void startEngine()
        {
            _engineStarted = true;
        }

        public bool engineIsStarted()
        {
            return _engineStarted;
        }

        public void stopEngine()
        {
            _engineStarted = false;
        }

        public abstract void fillUpWithFuel();

        public abstract void chargeBattery();
    }
}
