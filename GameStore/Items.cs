using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public abstract class Items
    {
        protected int StorePrice;
        protected int PlayerSellPrice;
        protected string itemSubClass = "";
        protected string RaceType = "";
        protected string ItemName = "";

        protected Items(int storePrice, int playerPrice, string itemSubClass, string raceType, string itemName)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.itemSubClass = itemSubClass;
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

                case "itemSubClass":
                    return this.itemSubClass;

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
