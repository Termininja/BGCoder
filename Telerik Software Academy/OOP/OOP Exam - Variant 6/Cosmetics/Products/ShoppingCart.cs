namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Null product cannot be added in the shopping cart!");
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Null product cannot be removed from the shopping cart!");
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.products.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.products.Sum(p => p.Price);
        }
    }
}
