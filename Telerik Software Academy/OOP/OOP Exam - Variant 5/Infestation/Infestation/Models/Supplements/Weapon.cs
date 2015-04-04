namespace Infestation
{
    public class Weapon : EffectSupplement
    {
        private const int WeaponPowerEffect = 10;
        private const int WeaponAggressionEffect = 3;

        public Weapon()
            : base(WeaponPowerEffect, 0, WeaponAggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.hasEffect = true;
            }
        }
    }
}
