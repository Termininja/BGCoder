namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const int MinimumCategoryNameLength = 2;
        private const int MaximumCategoryNameLength = 15;

        private string name;
        private IList<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "The category name cannot be null or empty!");
                Validator.CheckIfStringLengthIsValid(value, MaximumCategoryNameLength, MinimumCategoryNameLength,
                    string.Format(Constants.MinMaxStringFormatNameLength, this.GetType().Name, MinimumCategoryNameLength, MaximumCategoryNameLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Null cosmetics cannot be added in the category!");

            this.products.Add(cosmetics);

            //Products are sorted by brand in ascending order and then by price in descending order.
            this.products = this.products.OrderBy(p => p.Brand).ThenBy(p => -p.Price).ToList();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Null cosmetics cannot be removed from the category!");
            if (!this.products.Any(p => p == cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            var count = this.products.Count;
            var result = new StringBuilder();
            result.AppendFormat("{0} category - {1} {2} in total", this.Name, count, count == 1 ? "product" : "products");
            foreach (var product in this.products)
            {
                result.Append(Environment.NewLine + product.Print());
            }

            return result.ToString();
        }
    }
}