using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.CombatCalculator;

namespace TheGame.Battle
{
    public static class BattleSituation
    {
        public static bool BattleStart(Hero hero, Enemy enemy)
        {
            bool BattleContinues = true;
            bool HeroVictory = true;
            while (BattleContinues)
            {
                BattleRound(hero, enemy);

                if (hero.getHP() <= 0)
                {
                    HeroVictory = false;
                    BattleContinues = false;
                }
                else if (enemy.getHP() <= 0)
                {
                    HeroVictory = true;
                    BattleContinues = false;
                }
            }
            return HeroVictory;
        }

        public static void BattleRound (Hero hero, Enemy enemy)
        {
            Console.WriteLine("Select what sort of attack you wish to use!");
            Console.WriteLine("1. Normal Attack");
            Console.WriteLine("2. Risky attack (more damage, less likely to hit)");
            Console.WriteLine("3. Cautious attack (less damage, more likely to hit)");
        }
    }
}
