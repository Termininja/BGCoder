namespace Cosmetics.Products
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private const int MinimumIngredientNameLength = 4;
        private const int MaximumIngredientNameLength = 12;

        private IList<string> ingredientsList;

        public Toothpaste(string name, string brand, decimal price, Common.GenderType gender, IList<string> ingredientsList)
            : base(name, brand, price, gender)
        {
            this.IngredientsList = ingredientsList;
        }

        public IList<string> IngredientsList
        {
            get
            {
                return this.ingredientsList;
            }
            set
            {
                foreach (var ingredient in value)
                {
                    Validator.CheckIfStringLengthIsValid(ingredient, MaximumIngredientNameLength, MinimumIngredientNameLength,
                        string.Format("Each ingredient must be between {0} and {1} symbols long!",
                        MinimumIngredientNameLength, MaximumIngredientNameLength));
                }

                this.ingredientsList = value;
            }
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.IngredientsList);
            }
        }

        public override string ToString()
        {
            return string.Format("  * Ingredients: {0}", this.Ingredients);
        }
    }
}