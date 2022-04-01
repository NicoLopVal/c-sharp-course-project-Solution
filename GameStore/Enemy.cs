using System;
using System.Collections.Generic;
using System.Threading;

namespace RPGGame
{
    public class Enemy : LivingBeing
    {

        private List<string> NameList;
        
        public Enemy(int enemyCount)
        {
            NameList = new List<string>() { "Goblin", "Orc", "Golem", "Dragon" };
            Name = NameList[enemyCount];

            if (Name == "Goblin")
            {
                Level = 5;
                Health = 110;
                Attack = 110;
                Defense = 110;
                Technique = "Stone Throw";
            }
            else if (Name == "Orc")
            {
                Level = 10;
                Health = 150;
                Attack = 150;
                Defense = 150;
                Technique = "Axe Sweep";
            }
            else if (Name == "Golem")
            {
                Level = 20;
                Health = 500;
                Attack = 200;
                Defense = 200;
                Technique = "Totemstorm";
            }
            else if (Name == "Dragon")
            {
                Level = 50;
                Health = 1000;
                Attack = 300;
                Defense = 300;
                Technique = "Firebreath";
            }

            Console.WriteLine("{0} has appeared. Get ready to fight!", Name);
            Thread.Sleep(1000);
            Console.WriteLine("\nEnemy Stats\n" +
                "Health: {0}\n" +
                "Attack: {1}\n" +
                "Defense: {2}\n", Health, Attack, Defense);
            Thread.Sleep(1000);
        }
    }

}
