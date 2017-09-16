namespace Infestation
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class InfestUnit : Unit
    {
        public InfestUnit(string id, UnitClassification unitType, int health, int power, int aggression)
            : base(id, unitType, health, power, aggression)
        {
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            return this.Id != unit.Id &&
                InfestationRequirements.RequiredClassificationToInfest(unit.UnitClassification) == this.UnitClassification ? true : false;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            return attackableUnits.OrderBy(u => u.Health).FirstOrDefault();
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            var attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            var optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }
    }
}
