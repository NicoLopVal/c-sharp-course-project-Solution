using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Battle
{
    public static class LootDropCalculator
    {
        public static void DropLoot(Hero hero)
        {
            Random rand = new Random();
            int lootChance = rand.Next(1,20);
            int totalNewGold = 0;
            if(0 < lootChance && lootChance < 9)
                for (int i = 0; i < 4; i++)
                    totalNewGold += rand.Next(1, 6);
            else if (lootChance < 15)
                for (int i = 0; i < 6; i++)
                    totalNewGold += rand.Next(1, 8);
            else if (lootChance < 20)
                for (int i = 0; i < 8; i++)
                    totalNewGold += rand.Next(1, 10);
            else 
                for (int i = 0; i < 10; i++)
                    totalNewGold += rand.Next(1, 12);
            Console.WriteLine("Congratulations! You've earned " + totalNewGold + " gold pieces!");
            Console.WriteLine("Press Any key to continue!");
            Console.ReadKey();
            hero.AddMoneyToPurse(totalNewGold);

        }
    }
}
