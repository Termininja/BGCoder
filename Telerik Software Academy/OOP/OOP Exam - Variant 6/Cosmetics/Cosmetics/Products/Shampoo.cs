namespace Cosmetics.Products
{
    using System;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo, IProduct
    {
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price * milliliters, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; private set; }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
            private set
            {
                if (value != UsageType.EveryDay && value != UsageType.Medical)
                {
                    throw new ArgumentException("{0} is not allowed shampoo usage type!", value.ToString());
                }

                this.usage = value;
            }
        }

        public override string ToString()
        {
            var result = string.Format("  * Quantity: {0} ml" + Environment.NewLine, this.Milliliters);
            result += string.Format("  * Usage: {0}", this.Usage);

            return result;
        }
    }
}