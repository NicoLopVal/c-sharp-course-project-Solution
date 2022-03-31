using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class Armor : Items
    {
        private int DefenseProvided;
        private string ArmorPart = "";   //Shield, Helm, Plate, Gauntlets or Boots

        public Armor(int storePrice, int playerPrice, string itemType, string raceType, string itemName, int dafense, string armorPart) : base(storePrice, playerPrice, itemType, raceType, itemName)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.ItemType = itemType;
            this.RaceType = raceType;
            this.ItemName = itemName;
            this.DefenseProvided = dafense;
            this.ArmorPart = armorPart;
        }
    }
}
