namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model cannot be null or empty!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("The model cannot be with less than 3 symbols!");
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0m)
                {
                    throw new ArgumentException("The price cannot be less or equal to $0.00!");
                }

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0m)
                {
                    throw new ArgumentException("The height cannot be less or equal to 0.00m!");
                }

                this.height = value;
            }
        }

        public string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }
        }

        public MaterialType MaterialType { get; protected set; }

        public override string ToString()
        {
            var result = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height);

            return result;
        }
    }
}
