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
        public static void Attack (LivingBeing attacker, LivingBeing defender, int attackModifier)
        {
            var attackerDamageRoll = "";// = attacker.GetWeapon().GetWeaponDamageRoll();
            var attackRollModifier = attackModifier;
            var defenderArmorClass = defender.getArmorClass();
            int TotalDamage = 0;

            if(rollForAttack(attackRollModifier) > defenderArmorClass)
            {
                TotalDamage = DamageCalculation(attackerDamageRoll);
            }
            defender.takeDamage(TotalDamage);            
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
