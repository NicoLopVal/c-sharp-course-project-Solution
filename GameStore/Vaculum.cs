using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Vaculum : Weapon
    {
        public Vaculum(int storePrice, int playerPrice, string itemSubClass, string raceType, string itemName, string baseDamage)
            : base(storePrice, playerPrice, itemSubClass, raceType, itemName, baseDamage)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.itemSubClass = itemSubClass;
            this.RaceType = raceType;
            this.ItemName = itemName;
            this.BaseDamage = baseDamage;
        }
    }
}
