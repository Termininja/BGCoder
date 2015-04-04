namespace Infestation
{
    public abstract class EffectSupplement : Supplement
    {
        protected bool hasEffect;

        public EffectSupplement(int powerEffect, int healthEffect, int aggressionEffect)
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override int PowerEffect
        {
            get
            {
                if (!this.hasEffect)
                {
                    return 0;
                }

                return base.PowerEffect;
            }
            protected set
            {
                base.PowerEffect = value;
            }
        }

        public override int AggressionEffect
        {
            get
            {
                if (!this.hasEffect)
                {
                    return 0;
                }

                return base.AggressionEffect;
            }
            protected set
            {
                base.AggressionEffect = value;
            }
        }
    }
}
