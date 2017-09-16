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
                var targetUnit = this.GetUnit(commandWords[2]);
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
            switch (commandWords[1])
            {
                case "Tank":
                    unit = new Tank(commandWords[2]);
                    break;
                case "Marine":
                    unit = new Marine(commandWords[2]);
                    break;
                case "Parasite":
                    unit = new Parasite(commandWords[2]);
                    break;
                case "Queen":
                    unit = new Queen(commandWords[2]);
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
