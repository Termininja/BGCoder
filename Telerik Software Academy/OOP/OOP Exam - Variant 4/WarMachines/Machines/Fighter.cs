namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        private const double InitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, InitialHealthPoints, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = base.ToString() + string.Format("\n *Stealth: {0}", this.StealthMode ? "ON" : "OFF");

            return result;
        }
    }
}
