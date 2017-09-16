namespace Infestation
{
    public class HealthCatalyst : Supplement
    {
        private const int CatalystHealthEffect = 3;

        public HealthCatalyst()
            : base(0, CatalystHealthEffect, 0)
        {
        }
    }
}
