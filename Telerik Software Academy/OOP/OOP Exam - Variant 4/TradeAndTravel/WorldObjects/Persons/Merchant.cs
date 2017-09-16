namespace TradeAndTravel
{
    public class Merchant : Shopkeeper, ITraveller
    {
        public Merchant(string name, Location location)
            : base(name, location)
        {
        }

        public void TravelTo(Location location)
        {
            if (location != null)
            {
                this.Location = location;
            }
        }
    }
}
