using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class Items
    {
        protected int StorePrice;
        protected int PlayerSellPrice;
        protected string ItemType = "";       // Could be a weapon or armor
        protected string RaceType = "";
        protected string ItemName = "";

        protected Items(int storePrice, int playerPrice, string itemType, string raceType, string itemName)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.ItemType = itemType;
            this.RaceType = raceType;
            this.ItemName = itemName;
        }

        public string GetProperty(string property)
        {
            switch (property)
            {
                case "StorePrice":
                    return this.StorePrice.ToString();

                case "PlayerSellPrice":
                    return this.PlayerSellPrice.ToString();

                case "ItemType":
                    return this.ItemType;

                case "RaceType":
                    return this.RaceType;

                case "ItemName":
                    return this.ItemName;

                default:
                    return "A problem ocured.";
            }
        }
    }
}
