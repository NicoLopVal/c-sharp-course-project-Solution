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
            Console.Clear();
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


            bool invalidImput = false;
            do {
                int attackChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You've damaged your enemy by:");
                switch (attackChoice)
                {
                    case 1:
                        {
                            enemy.takeDamage(CombatCalculator.CombatCalculator.Attack(hero.getAttackRoll(), enemy.getArmorClass(), 0, 0));
                            invalidImput = false;
                        } break;
                    case 2:
                        {
                            enemy.takeDamage(CombatCalculator.CombatCalculator.Attack(hero.getAttackRoll(), enemy.getArmorClass(), -1, 4));
                            invalidImput = false;
                        }
                        break;
                    case 3:
                        {
                            enemy.takeDamage(CombatCalculator.CombatCalculator.Attack(hero.getAttackRoll(), enemy.getArmorClass(), 1, -2));
                            invalidImput = false;
                        }
                        break;
                    default:
                        {
                            invalidImput = true;
                        }break;
                }
            } while (invalidImput);
            Console.WriteLine("The enemy has dealt you damaged by:");
            hero.takeDamage(CombatCalculator.CombatCalculator.Attack(enemy.getAttackRoll(), hero.getArmorClass(), 0, 0));

            Thread.Sleep(1500);
        }
    }
}
