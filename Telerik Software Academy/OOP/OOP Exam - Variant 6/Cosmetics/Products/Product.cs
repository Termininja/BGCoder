namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private const int MinimumProductNameLength = 3;
        private const int MaximumProductNameLength = 10;
        private const int MinimumProductBrandNameLength = 2;
        private const int MaximumProductBrandNameLength = 10;

        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "The product name cannot be null or empty!");
                Validator.CheckIfStringLengthIsValid(value, MaximumProductNameLength, MinimumProductNameLength,
                    string.Format(Constants.MinMaxStringFormatNameLength, base.GetType().BaseType.Name, MinimumProductNameLength, MaximumProductNameLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "The product brand cannot be null or empty!");
                Validator.CheckIfStringLengthIsValid(value, MaximumProductBrandNameLength, MinimumProductBrandNameLength,
                    string.Format("Product brand must be between {0} and {1} symbols long!", MinimumProductBrandNameLength, MaximumProductBrandNameLength));

                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                if (value != GenderType.Men && value != GenderType.Women && value != GenderType.Unisex)
                {
                    throw new ArgumentException("{0} is not allowed product gender type!", value.ToString());
                }

                this.gender = value;
            }
        }

        private static void NewMethod(GenderType value, Type temp)
        {
            Enum.GetName(temp, value);
        }

        public string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));
            result.Append(this.ToString());

            return result.ToString();
        }
    }
}
