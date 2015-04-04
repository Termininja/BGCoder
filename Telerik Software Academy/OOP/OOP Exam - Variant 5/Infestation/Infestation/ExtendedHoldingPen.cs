namespace Infestation
{
    public class ExtendedHoldingPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            Supplement supplement = null;

            switch (commandWords[1])
            {
                case "Weapon":
                    supplement = new Weapon();
                    break;
                case "HealthCatalyst":
                    supplement = new HealthCatalyst();
                    break;
                case "PowerCatalyst":
                    supplement = new PowerCatalyst();
                    break;
                case "AggressionCatalyst":
                    supplement = new AggressionCatalyst();
                    break;
                default:
                    break;
            }

            if (supplement != null)
            {
                var targetId = commandWords[2];
                var targetUnit = this.GetUnit(targetId);
                targetUnit.AddSupplement(supplement);
            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            if (interaction.InteractionType == InteractionType.Infest)
            {
                var targetUnit = this.GetUnit(interaction.TargetUnit);
                targetUnit.AddSupplement(new InfestationSpores());
            }
            else
            {
                base.ProcessSingleInteraction(interaction);
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            Unit unit = null;
            var unitId = commandWords[2];
            switch (commandWords[1])
            {
                case "Tank":
                    unit = new Tank(unitId);
                    break;
                case "Marine":
                    unit = new Marine(unitId);
                    break;
                case "Parasite":
                    unit = new Parasite(unitId);
                    break;
                case "Queen":
                    unit = new Queen(unitId);
                    break;
                default:
                    break;
            }

            if (unit != null)
            {
                base.InsertUnit(unit);
            }

            base.ExecuteInsertUnitCommand(commandWords);
        }
    }
}
