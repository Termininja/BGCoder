using System;
using System.Linq;

namespace TradeAndTravel
{
    public class ExtendedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleGatherInteraction(Person actor, string name)
        {
            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;
                if (actor.HasItem(gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(name));
                }
            }
        }

        private void HandleCraftInteraction(Person actor, string type, string name)
        {
            if (type == "armor" && actor.HasItem(ItemType.Iron))
            {
                this.AddToPerson(actor, new Armor(name));
            }

            if (type == "weapon" && actor.HasItem(ItemType.Iron) && actor.HasItem(ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(name));
            }
        }
    }
}