using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace TheGame.CombatCalculator
{
    public static class CombatCalculator
    {
        public static void Attack(LivingBeing attacker, LivingBeing defender, int rollModifier, int attackModifier)
        {
            var attackerDamageRoll = attacker.getAttackRoll();
            var attackRollModifier = rollModifier + attacker.getAttackRollModifier();
            var defenderArmorClass = defender.getArmorClass();
            int TotalDamage = 0;
            int attackRoll = rollForAttack(attackRollModifier) + rollModifier;


            if (attackRoll == 20)
                TotalDamage = (DamageCalculation(attackerDamageRoll) + attackModifier)*2;
            else if(attackRoll > defenderArmorClass)
            {
                TotalDamage = DamageCalculation(attackerDamageRoll) + attackModifier;
                if (TotalDamage < 1)
                    TotalDamage = 1;
            }
            defender.takeDamage(TotalDamage);
            Console.WriteLine(TotalDamage + " HP");
        }

        /*public static void SpellCasting(Spell spell, LivingBeing defender)
        {
            var damageRoll = spell.getDamageModifier();
        }*/

        private static int rollForAttack (int attackRollModifier)
        {
            Random rand = new Random();
            return rand.Next(1,20) + attackRollModifier;
        }

        private static int DamageCalculation (string DamageRoll)
        {
            String[] DamageValues = DamageRoll.Split('d');
            int TotalDamage = 0;
            Random rand = new Random();
            for(int i = 0; i < int.Parse(DamageValues[0]); i++)
            {
                TotalDamage += rand.Next(1, int.Parse(DamageValues[1]));
            }
            return TotalDamage;
        }
    }
}
