namespace lsp
{
    public abstract class Vehicle : IChargable, IRefuelable
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

        public abstract void Refuel();
        public abstract void Charge();
    }
}
