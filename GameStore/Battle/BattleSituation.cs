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
                    hero.restoreHP();
                }
            }
            return HeroVictory;
        }

        public static void BattleRound (Hero hero, Enemy enemy)
        {
            Console.WriteLine("Your HP: " + hero.getHP());
            Console.WriteLine("Your Attack: " + hero.getAttackRoll());
            Console.WriteLine("Your Armor: " + hero.getArmorClass());
            Console.WriteLine("Enemy HP: " + enemy.getHP());
            Console.WriteLine("Enemy Attack: " + enemy.getAttackRoll());
            Console.WriteLine("Enemy Armor: " + enemy.getArmorClass());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select what sort of attack you wish to use!");
            Console.WriteLine("1. Normal Attack");
            Console.WriteLine("2. Risky attack (more damage, less likely to hit)");
            Console.WriteLine("3. Cautious attack (less damage, more likely to hit)");

            Console.Clear();
            Console.WriteLine("You've damaged your enemy by:");
            bool invalidImput = false;
            do {
                int attackChoice = Convert.ToInt32(Console.ReadLine());
                switch (attackChoice)
                {
                    case 1:
                        {
                            CombatCalculator.CombatCalculator.Attack(hero, enemy, 0, 0);
                        } break;
                    case 2:
                        {
                            CombatCalculator.CombatCalculator.Attack(hero, enemy, 0, 4);
                        }
                        break;
                    case 3:
                        {
                            CombatCalculator.CombatCalculator.Attack(hero, enemy, 0, -2);
                        }
                        break;
                    default:
                        {
                            invalidImput = true;
                        }break;
                }
            } while (!invalidImput);
            Console.WriteLine("The enemy has dealt you damaged by:");
            CombatCalculator.CombatCalculator.Attack(enemy, hero, 0, 0);
        }
    }
}
