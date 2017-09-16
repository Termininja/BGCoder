namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int MoneyValue = 3;

        public Iron(string name, Location location = null)
            : base(name, MoneyValue, ItemType.Iron, location)
        {
        }
    }
}
