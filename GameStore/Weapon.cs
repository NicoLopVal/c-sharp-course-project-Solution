﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class Weapon : Items
    {
        private int AttackRating;
        private int BaseDamage;
        public Weapon(int storePrice, int playerPrice, string itemType, string raceType, string itemName, int attackRating, int baseDamage) : base(storePrice, playerPrice, itemType, raceType, itemName)
        {
            this.StorePrice = storePrice;
            this.PlayerSellPrice = playerPrice;
            this.ItemType = itemType;
            this.RaceType = raceType;
            this.ItemName = itemName;
            this.AttackRating = attackRating;
            this.BaseDamage = baseDamage;
        }
    }
}