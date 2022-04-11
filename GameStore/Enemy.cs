using System;
using System.Collections.Generic;
using System.Threading;

namespace TheGame
{
    public class Enemy : LivingBeing
    {
        private List<Items> ItemList;
        private List<string> NameList;
        
        public Enemy(int enemyCount)
        {
            NameList = new List<string>() { "Goblin", "Orc", "Golem", "Dragon" };
            Name = NameList[enemyCount];

            if (Name == "Goblin")
            {
                Level = 5;
                maxHealth = 110;
                currentHealth = maxHealth;
                Attack = "1d4";
                ArmorClass = 8;
                Technique = "Stone Throw";
            }
            else if (Name == "Orc")
            {
                Level = 10;
                maxHealth = 150;
                currentHealth = maxHealth;
                Attack = "2d4";
                ArmorClass = 10;
                Technique = "Axe Sweep";
            }
            else if (Name == "Golem")
            {
                Level = 20;
                maxHealth = 500;
                currentHealth = maxHealth;
                Attack = "3d4";
                ArmorClass = 13;
                Technique = "Totemstorm";
            }
            else if (Name == "Dragon")
            {
                Level = 50;
                maxHealth = 1000;
                currentHealth = maxHealth;
                Attack = "5d6";
                ArmorClass = 15;
                Technique = "Firebreath";
            }

            Console.WriteLine("{0} has appeared. Get ready to fight!", Name);
            Thread.Sleep(1000);
            Console.WriteLine("\nEnemy Stats\n" +
                "Health: {0}\n" +
                "Attack: {1}\n" +
                "Defense: {2}\n", currentHealth, Attack, ArmorClass);
            Thread.Sleep(1000);
        }
    }

}
