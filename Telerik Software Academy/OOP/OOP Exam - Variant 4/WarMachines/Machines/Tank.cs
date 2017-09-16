namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private const double InitialHealthPoints = 100;
        private const double IncreaseDefensePoints = 30;
        private const double DecreaseAttackPoints = 40;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, InitialHealthPoints, attackPoints, defensePoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                base.DefensePoints += IncreaseDefensePoints;
                base.AttackPoints -= DecreaseAttackPoints;
            }
            else
            {
                base.DefensePoints -= IncreaseDefensePoints;
                base.AttackPoints += DecreaseAttackPoints;
            }
        }

        public override string ToString()
        {
            var result = base.ToString() + string.Format("\n *Defense: {0}", this.DefenseMode ? "ON" : "OFF");

            return result;
        }
    }
}
