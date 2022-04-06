using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    internal class Helmet : Armor
    {
        public Helmet(int storePrice, int playerPrice, string itemSubClass, string raceType, string itemName, int defense)
            : base(storePrice, playerPrice, itemSubClass, raceType, itemName, defense)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.itemSubClass = itemSubClass;
            this.RaceType = raceType;
            this.ItemName = itemName;
            this.DefenseProvided = defense;
        }
    }
}
