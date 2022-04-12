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
        public static int Attack(string attackerDamageRoll, int defenderArmorClass, int rollModifier, int attackModifier)
        {
            int TotalDamage = 0;
            int attackRoll = rollForAttack(rollModifier);


            if (attackRoll == 20)
                TotalDamage = (DamageCalculation(attackerDamageRoll) + attackModifier)*2;
            else if(attackRoll > defenderArmorClass)
            {
                TotalDamage = DamageCalculation(attackerDamageRoll) + attackModifier;
                if (TotalDamage < 1)
                    TotalDamage = 1;
            }
            
            Console.WriteLine(TotalDamage + " HP");
            return TotalDamage;
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
