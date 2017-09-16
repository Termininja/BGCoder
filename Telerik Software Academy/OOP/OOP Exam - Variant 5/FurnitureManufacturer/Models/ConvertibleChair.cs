namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedHeight = 0.10m;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public bool IsConverted { get; private set; }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
        }

        public override decimal Height
        {
            get
            {
                return this.IsConverted ? ConvertedHeight : base.Height;
            }
            protected set
            {
                base.Height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
