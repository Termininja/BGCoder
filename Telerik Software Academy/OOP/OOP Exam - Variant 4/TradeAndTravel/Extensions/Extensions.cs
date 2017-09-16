using System.Linq;

namespace TradeAndTravel
{
    public static class Extensions
    {
        public static bool HasItem(this Person actor, ItemType itemType)
        {
            return actor.ListInventory().Any(i => i.ItemType == itemType);
        }
    }
}
