namespace Infestation
{
    public class InfestationSpores : EffectSupplement
    {
        private const int InfestationSporesPowerEffect = -1;
        private const int InfestationSporesAggressionEffect = 20;

        public InfestationSpores()
            : base(InfestationSporesPowerEffect, 0, InfestationSporesAggressionEffect)
        {
            this.hasEffect = true;
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.hasEffect = false;
            }
        }
    }
}
