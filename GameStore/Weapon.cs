using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Weapon : Items
    {
        private int AttackRating;
        private string BaseDamage;
        public Weapon(int storePrice, int playerPrice, string itemType, string raceType, string itemName, int attackRating, string baseDamage) : base(storePrice, playerPrice, itemType, raceType, itemName)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.ItemType = itemType;
            this.RaceType = raceType;
            this.ItemName = itemName;
            this.AttackRating = attackRating;
            this.BaseDamage = baseDamage;
        }

        public string GetWeaponDamageRoll()
        {
            return this.BaseDamage;
        }
    }
}
